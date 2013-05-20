using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class MainForm : Form
    {
        private delegate void DeliveryReceivedHandler(ServiceDataTypes.Delivery delivery);
        private delegate void OrderReceivedHandler(ServiceDataTypes.Order order);
        private delegate void OrderStateUpdatedHandler(ServiceDataTypes.Order order);

        private DeliveryReceivedHandler deliveryReceived;
        private OrderReceivedHandler orderReceived;
        private OrderStateUpdatedHandler orderStateUpdated;

        public MainForm()
        {
            InitializeComponent();
            RefreshStoreStockListView();
            RefreshWaitingDeliveryListView();
            RefreshCompletedDeliveryListView();
            RefreshWaitingOrderListView();
            RefreshCompletedOrderListView();
            StoreManager.Instance.DeliveryReceivedEvent += new StoreManager.DeliveryReceivedHandler(DeliveryReceived);
            StoreManager.Instance.OrderReceivedEvent += new StoreManager.OrderReceivedHandler(OrderReceived);
            StoreManager.Instance.OrderStateUpdatedEvent += new StoreManager.OrderStateUpdatedHandler(OrderStateUpdated);
            this.deliveryReceived = new DeliveryReceivedHandler(DeliveryReceived);
            this.orderReceived = new OrderReceivedHandler(OrderReceived);
            this.orderStateUpdated = new OrderStateUpdatedHandler(OrderStateUpdated);
        }

        private void DeliveryReceived(ServiceDataTypes.Delivery delivery)
        {
            if (InvokeRequired)
            {
                Invoke(this.deliveryReceived, new object[] { delivery });
            }
            else
            {
                ServiceDataTypes.Order order = delivery.Order;
                ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), order.OrderID.ToString(), order.Book.Title, order.Book.Author, delivery.Quantity.ToString() });
                this.WaitingDeliveryListView.Items.Add(item);
            }
        }

        private void OrderReceived(ServiceDataTypes.Order order)
        {
            if (InvokeRequired)
            {
                Invoke(this.orderReceived, new object[] { order });
            }
            else
            {
                this.RefreshStoreStockListView();
                this.RefreshWaitingDeliveryListView();
                this.RefreshCompletedDeliveryListView();
                this.RefreshWaitingOrderListView();
                this.RefreshCompletedOrderListView();
            }
        }

        private void OrderStateUpdated(ServiceDataTypes.Order order)
        {
            if (InvokeRequired)
            {
                Invoke(this.orderStateUpdated, new object[] { order });
            }
            else
            {
                this.RefreshWaitingOrderListView();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start the services.
            StoreServiceHost.Instance.StartServices();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop the services.
            StoreServiceHost.Instance.StopServices();
        }

        /// <summary>
        /// Updates the store stock list view.
        /// </summary>
        private void RefreshStoreStockListView()
        {
            // Clear existing items.
            this.StoreStockListView.Items.Clear();

            using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
            {
                foreach (var book in context.Books)
                {
                    ListViewItem item = new ListViewItem(new string[] { book.BookID.ToString(), book.Title, book.Author, String.Format("{0:N} Euros", book.Price), book.Stocks[0].Copies.ToString() });
                    this.StoreStockListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Updates the waiting deliveries list view.
        /// </summary>
        private void RefreshWaitingDeliveryListView()
        {
            // Clear existing items.
            this.WaitingDeliveryListView.Items.Clear();

            using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
            {
                foreach (var delivery in context.Deliveries.Where(d => d.Accepted == false))
                {
                    var order = delivery.Order;
                    ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), order.OrderID.ToString(), order.Book.Title, order.Book.Author, delivery.Quantity.ToString() });
                    this.WaitingDeliveryListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Updates the waiting orders list view.
        /// </summary>
        private void RefreshWaitingOrderListView()
        {
            // Clear existing items.
            this.WaitingOrderListView.Items.Clear();

            using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
            {
                foreach (var order in context.Orders.Where(o => o.State == ServiceDataTypes.OrderState.FutureDispatch.ToString() || o.State == ServiceDataTypes.OrderState.WaitingExpedition.ToString()))
                {
                    ListViewItem item = new ListViewItem(new string[] { order.OrderID.ToString(), order.State, order.ExpDate == null ? "" : String.Format("{0:d}", order.ExpDate), order.Book.Title, order.Email, order.Quantity.ToString(), (order.Quantity * order.Book.Price).ToString() });
                    this.WaitingOrderListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Updates the completed orders list view.
        /// </summary>
        private void RefreshCompletedOrderListView()
        {
            // Clear existing items.
            this.CompletedOrderListView.Items.Clear();

            using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
            {
                foreach (var order in context.Orders.Where(o => o.State == ServiceDataTypes.OrderState.Dispatched.ToString()))
                {
                    ListViewItem item = new ListViewItem(new string[] { order.OrderID.ToString(), order.State, order.ExpDate == null ? "" : String.Format("{0:d}", order.ExpDate), order.Book.Title, order.Email, order.Quantity.ToString(), (order.Quantity * order.Book.Price).ToString() });
                    this.CompletedOrderListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Updates the completed deliveries list view.
        /// </summary>
        private void RefreshCompletedDeliveryListView()
        {
            // Clear existing items.
            this.CompletedDeliveryListView.Items.Clear();

            using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
            {
                foreach (var delivery in context.Deliveries.Where(d => d.Accepted == true))
                {
                    var order = delivery.Order;
                    ListViewItem item = new ListViewItem(new string[] { delivery.DeliveryID.ToString(), order.OrderID.ToString(), order.Book.Title, order.Book.Author, delivery.Quantity.ToString() });
                    this.CompletedDeliveryListView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Action when sale button is pressed.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void MakeSaleButton_Click(object sender, EventArgs e)
        {
            if (this.StoreStockListView.SelectedItems.Count > 0)
            {
                ListViewItem item = this.StoreStockListView.SelectedItems[0];
                using (StoreDataClassesDataContext context = new StoreDataClassesDataContext())
                {
                    var book = context.Books.FirstOrDefault(b => b.BookID == int.Parse(item.SubItems[0].Text));
                    SellPopupForm popup = new SellPopupForm(book.Price);
                    DialogResult dialogresult = popup.ShowDialog();

                    // Order was confirmed.
                    if (dialogresult == System.Windows.Forms.DialogResult.OK)
                    {
                        int quantity = popup.Quantity;
                        var stock = context.Stocks.FirstOrDefault(s => s.BookID == book.BookID);

                        // Simple sale, no need to order or register.
                        if (stock.Copies >= quantity)
                        {
                            stock.Copies -= quantity;
                            context.SubmitChanges();
                            ServiceDataTypes.Receipt receipt = new ServiceDataTypes.Receipt()
                            {
                                BookQuantity = quantity,
                                BookTitle = book.Title,
                                ClientName = popup.Name,
                                TotalPrice = quantity * book.Price
                            };
                            NotificationService.NotificationService.Instance.NotifyPrinters(receipt);
                            this.RefreshStoreStockListView();
                        }
                        // Not enough books, order needed.
                        else
                        {
                            BookStoreService.BookStoreService service = new BookStoreService.BookStoreService();
                            ServiceDataTypes.Order order = new ServiceDataTypes.Order
                            {
                                Book = new ServiceDataTypes.Book { BookID = book.BookID },
                                Client = new ServiceDataTypes.Client { Name = popup.Name, Address = popup.Address, Email = popup.Email },
                                Quantity = quantity
                            };
                            order = service.CreateOrder(order);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Action when accept button is pressed.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void AcceptDeliveryButton_Click(object sender, EventArgs e)
        {
            if (this.WaitingDeliveryListView.SelectedItems.Count > 0)
            {
                ListViewItem item = this.WaitingDeliveryListView.SelectedItems[0];
                BookStoreService.BookStoreService service = new BookStoreService.BookStoreService();
                service.AcceptDelivery(int.Parse(item.SubItems[0].Text));
                this.RefreshWaitingOrderListView();
                this.RefreshCompletedOrderListView();
                this.RefreshCompletedDeliveryListView();
                this.RefreshWaitingDeliveryListView();
            }
        }
    }
}
