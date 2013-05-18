using VirtualPrinter.NotificationService;

namespace VirtualPrinter
{
    public class Printer : INotificationServiceCallback
    {
        private NotificationServiceClient NotificationsClient { get; set; }

        public bool Connected { get; private set; }

        /// <summary>
        /// Instantiates a new virtual printer.
        /// </summary>
        public Printer()
        {
            this.Connected = false;
            this.NotificationsClient = null;
        }

        /// <summary>
        /// Connects to the service.
        /// </summary>
        public void Connect()
        {
            try
            {
                // Stop the client if already running.
                if (this.NotificationsClient != null)
                {
                    this.NotificationsClient.UnsubscribePrinter();
                    this.NotificationsClient.Close();
                    this.NotificationsClient = null;
                    this.Connected = false;
                }

                // Create a new client instance.
                this.NotificationsClient = new NotificationServiceClient(new System.ServiceModel.InstanceContext(this));
                this.NotificationsClient.Open();
                this.NotificationsClient.SubscribePrinter();
                this.Connected = true;
            }
            catch (System.Exception)
            {
                this.NotificationsClient = null;
                this.Connected = false;
            }
        }

        /// <summary>
        /// Disconnects from the service.
        /// </summary>
        public void Disconnect()
        {
            try
            {
                // Stop the client if already running.
                if (this.NotificationsClient != null)
                {
                    this.NotificationsClient.UnsubscribePrinter();
                    this.NotificationsClient.Close();
                    this.NotificationsClient = null;
                }
                this.Connected = false;
            }
            catch (System.Exception)
            {
                this.NotificationsClient = null;
                this.Connected = false;
            }
        }

        /// <summary>
        /// Prints a received receipt.
        /// </summary>
        /// <param name="receipt">Receipt to print</param>
        public void PrintReceipt(Receipt receipt)
        {
            System.Console.WriteLine("\n\n------------------------");
            System.Console.WriteLine("{0,-15}{1}", "Order ID:", receipt.OrderID);
            System.Console.WriteLine("{0,-15}{1}", "Client Name:", receipt.ClientName);
            System.Console.WriteLine("{0,-15}{1}", "Store NIF:", "123456789");
            System.Console.WriteLine("{0,-15}{1} x{2}", "Order:", receipt.BookTitle, receipt.BookQuantity);
            System.Console.WriteLine("{0,-15}{1:N} Euros", "Total Price:", receipt.TotalPrice);
            System.Console.WriteLine("------------------------");
        }

        /// <summary>
        /// Not implemented as it isn't needed.
        /// </summary>
        /// <param name="email">Email to redirect</param>
        public void SendEmail(Email email)
        {
            // Never called, no need to implement.
            throw new System.NotImplementedException();
        }

        public static void Main(string[] args)
        {
            // Instantiate the client.
            Printer printer = new Printer();
            System.Console.WriteLine("Virtual printer initiated. Trying to connect to service.\n\n");
            bool exit = false;

            // Loop until the user wants to quit.
            while (!exit)
            {
                printer.Connect();
                if (printer.Connected)
                {
                    System.Console.WriteLine("Successfully connected to the service. Will now print incoming receipts.");
                    System.ConsoleKeyInfo key;
                    do
                    {
                        System.Console.WriteLine("Press <ENTER> to disconnect and quit.");
                        key = System.Console.ReadKey();
                        System.Console.Clear();
                    }
                    while (key.Key != System.ConsoleKey.Enter);
                    exit = true;
                }
                else
                {
                    System.Console.WriteLine("Failed to connect to the service.");
                    System.ConsoleKeyInfo key;
                    do
                    {
                        System.Console.WriteLine("Press <ENTER> to quit, press <SPACE> to reconnect.");
                        key = System.Console.ReadKey();
                        System.Console.Clear();
                    }
                    while (key.Key != System.ConsoleKey.Enter && key.Key != System.ConsoleKey.Spacebar);

                    // Exit if enter is pressed.
                    if (key.Key == System.ConsoleKey.Enter)
                    {
                        exit = true;
                    }
                    else
                    {
                        System.Console.WriteLine("Reconnecting to the service.");
                    }
                }
            }
            System.Console.WriteLine("Disconnecting from the service.");
            printer.Disconnect();
        }
    }
}