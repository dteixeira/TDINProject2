using System;
using System.Linq;
using System.Messaging;
using System.Windows.Forms;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        private readonly static string QueueName = @".\private$\TDINStoreWarehouseQueue";

        private delegate void UpdateListHandler(Delivery delivery);

        private UpdateListHandler pendentDeliveryListUpdater;
        private UpdateListHandler completedDeliveryListUpdater;

        public MessageQueue Queue { get; private set; }

        public BookStoreService.BookStoreServiceClient BookStoreClient { get; private set; }

        /// <summary>
        /// Instantiates a new MainForm window.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeQueue();
            InitializeServiceClient();
            RefreshCompletedDeliveryList();
            RefreshPendentDeliveryList();

            // Registers an handler to update the list
            // when a new order is received.
            this.pendentDeliveryListUpdater = new UpdateListHandler(AddToPendentDeliveryList);
            this.completedDeliveryListUpdater = new UpdateListHandler(AddToCompletedDeliveryList);
        }

        /// <summary>
        /// Initializes the connection to the book store service.
        /// </summary>
        private void InitializeServiceClient()
        {
            try
            {
                this.BookStoreClient = new BookStoreService.BookStoreServiceClient();
                this.BookStoreClient.Open();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Initializes the connection with the MSMQ.
        /// </summary>
        private void InitializeQueue()
        {
            try
            {
                // Creates a new queue if it doesn't exist.
                if (!MessageQueue.Exists(MainForm.QueueName))
                {
                    MessageQueue.Create(MainForm.QueueName);
                }

                // Connects and configures queue.
                this.Queue = new MessageQueue(MainForm.QueueName);
                this.Queue.Formatter = new XmlMessageFormatter(new Type[] { typeof(BookStoreService.Order) });
                this.Queue.ReceiveCompleted += new ReceiveCompletedEventHandler(ReceiveOrderCompleted);
                this.Queue.BeginReceive();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Handles messages received from the store.
        /// </summary>
        /// <param name="source">Source of the message</param>
        /// <param name="asyncResult">Asynchronous operation result</param>
        private void ReceiveOrderCompleted(Object source, ReceiveCompletedEventArgs asyncResult)
        {
            try
            {
                // Receive order.
                MessageQueue queue = (MessageQueue)source;
                System.Messaging.Message message = queue.EndReceive(asyncResult.AsyncResult);
                BookStoreService.Order order = (BookStoreService.Order)message.Body;

                // Add delivery request to the dabase.
                using (WarehouseDataClassesDataContext context = new WarehouseDataClassesDataContext())
                {
                    Delivery delivery = new Delivery
                    {
                        OrderID = order.OrderID,
                        BookAuthor = order.Book.Author,
                        BookID = order.Book.BookID,
                        BookTitle = order.Book.Title,
                        Completed = false,
                        Quantity = order.Quantity
                    };
                    context.Deliveries.InsertOnSubmit(delivery);
                    context.SubmitChanges();

                    // Update the interface.
                    this.AddToPendentDeliveryList(delivery);
                }

                // Start receiving again.
                this.Queue.BeginReceive();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Adds a new item to the pendent deliveries list.
        /// </summary>
        /// <param name="delivery">Item to add</param>
        private void AddToPendentDeliveryList(Delivery delivery)
        {
            if (InvokeRequired)
            {
                Invoke(this.pendentDeliveryListUpdater, new object[] { delivery });
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), delivery.OrderID.ToString(), delivery.BookTitle, delivery.BookAuthor, delivery.Quantity.ToString() });
                this.PendentDeliveryListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Adds a new item to the completed deliveries list.
        /// </summary>
        /// <param name="delivery"></param>
        private void AddToCompletedDeliveryList(Delivery delivery)
        {
            if (InvokeRequired)
            {
                Invoke(this.completedDeliveryListUpdater, new object[] { delivery });
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), delivery.OrderID.ToString(), delivery.BookTitle, delivery.BookAuthor, delivery.Quantity.ToString() });
                this.CompletedDeliveryListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Completetly wipes and rebuilds the information in the
        /// pendent deliveries list.
        /// </summary>
        private void RefreshPendentDeliveryList()
        {
            // Clear existing items.
            this.PendentDeliveryListView.Items.Clear();

            using (WarehouseDataClassesDataContext context = new WarehouseDataClassesDataContext())
            {
                var pendent = context.Deliveries.Where(d => d.Completed == false);
                foreach (var delivery in pendent)
                {
                    ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), delivery.OrderID.ToString(), delivery.BookTitle, delivery.BookAuthor, delivery.Quantity.ToString() });
                    this.PendentDeliveryListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Completetly wipes and rebuilds the information in the
        /// completed deliveries list.
        /// </summary>
        private void RefreshCompletedDeliveryList()
        {
            // Clear existing items.
            this.CompletedDeliveryListView.Items.Clear();

            using (WarehouseDataClassesDataContext context = new WarehouseDataClassesDataContext())
            {
                var pendent = context.Deliveries.Where(d => d.Completed == true);
                foreach (var delivery in pendent)
                {
                    ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), delivery.OrderID.ToString(), delivery.BookTitle, delivery.BookAuthor, delivery.Quantity.ToString() });
                    this.CompletedDeliveryListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Handles the click to process a pending delivery.
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Event arguments</param>
        private void CompleteDeliveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.PendentDeliveryListView.SelectedItems.Count > 0)
                {
                    ListViewItem item = this.PendentDeliveryListView.SelectedItems[0];
                    int deliveryID = int.Parse(item.SubItems[0].Text);
                    using (WarehouseDataClassesDataContext context = new WarehouseDataClassesDataContext())
                    {
                        var delivery = context.Deliveries.FirstOrDefault(d => d.DeliveryID == deliveryID);

                        // Notify the service about the delivery and
                        // update the order state.
                        if (delivery != null)
                        {
                            // Change order state.
                            BookStoreService.Order order = new BookStoreService.Order
                            {
                                OrderID = delivery.OrderID,
                                State = BookStoreService.OrderState.FutureDispatch,
                                ExpDate = DateTime.Today.AddDays(2)
                            };
                            this.BookStoreClient.UpdateOrderState(order);

                            // Send delivery.
                            BookStoreService.Stock stock = new BookStoreService.Stock
                            {
                                Book = new BookStoreService.Book { BookID = delivery.BookID },
                                Copies = delivery.Quantity * 10
                            };
                            this.BookStoreClient.SendStock(stock);

                            // Update the delivery state.
                            delivery.Completed = true;
                            context.SubmitChanges();

                            // Add the delivery to the completed deliveris list.
                            this.AddToCompletedDeliveryList(delivery);
                        }
                    }

                    // Remove the selected item.
                    this.PendentDeliveryListView.Items.Remove(item);
                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the service client.
            this.BookStoreClient.Close();
            
            // Closes the queue connection.
            this.Queue.Close();
        }
    }
}