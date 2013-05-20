using VirtualEmailServer.NotificationService;

namespace VirtualPrinter
{
    public class EmailServer : INotificationServiceCallback
    {
        private NotificationServiceClient NotificationsClient { get; set; }

        public bool Connected { get; private set; }

        /// <summary>
        /// Instantiates a new virtual email server.
        /// </summary>
        public EmailServer()
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
                    this.NotificationsClient.UnsubscribeEmailServer();
                    this.NotificationsClient.Close();
                    this.NotificationsClient = null;
                    this.Connected = false;
                }

                // Create a new client instance.
                this.NotificationsClient = new NotificationServiceClient(new System.ServiceModel.InstanceContext(this));
                this.NotificationsClient.Open();
                this.NotificationsClient.SubscribeEmailServer();
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
                    this.NotificationsClient.UnsubscribeEmailServer();
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
        /// Not implemented as it isn't needed.
        /// </summary>
        /// <param name="receipt">Receipt to print</param>
        public void PrintReceipt(Receipt receipt)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Redirects a received email.
        /// </summary>
        /// <param name="email">Email to redirect</param>
        public void SendEmail(Email email)
        {
            System.Console.WriteLine("\n\n------------------------");
            System.Console.WriteLine("Sent to: {0}\n", email.Client.Email);
            System.Console.WriteLine("Dear {0},\n\n", email.Client.Name);
            System.Console.WriteLine("Your order of {0} unit(s) of \"{1}\"", email.BookQuantity, email.BookTitle);
            System.Console.WriteLine("was dispatched on {0:d}, and will arrive", email.DispatchDate);
            System.Console.WriteLine("to {0} in the next few days.", email.Client.Address);
            System.Console.WriteLine("A total of {0:N} Euros have been charged to your account.", email.TotalPrice);
            System.Console.WriteLine("\nThank you for shopping with us.");
            System.Console.WriteLine("Best regards, The Management");
            System.Console.WriteLine("\n******Order details******");
            System.Console.WriteLine("{0,-15}{1}", "Order ID:", email.OrderID);
            System.Console.WriteLine("{0,-15}{1}", "Client Name:", email.Client.Name);
            System.Console.WriteLine("{0,-15}{1}", "Client Address:", email.Client.Address);
            System.Console.WriteLine("{0,-15}{1}", "Store NIF:", "123456789");
            System.Console.WriteLine("{0,-15}{1} x{2}", "Order:", email.BookTitle, email.BookQuantity);
            System.Console.WriteLine("{0,-15}{1:N} Euros", "Total Price:", email.TotalPrice);
            System.Console.WriteLine("------------------------");
        }

        public static void Main(string[] args)
        {
            // Instantiate the client.
            EmailServer emailServer = new EmailServer();
            System.Console.WriteLine("Virtual email server initiated. Trying to connect to service.\n\n");
            bool exit = false;

            // Loop until the user wants to quit.
            while (!exit)
            {
                emailServer.Connect();
                if (emailServer.Connected)
                {
                    System.Console.WriteLine("Successfully connected to the service. Will now redirect incoming emails.");
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
            emailServer.Disconnect();
        }
    }
}