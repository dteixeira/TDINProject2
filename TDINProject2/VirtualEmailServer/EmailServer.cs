using System.Net.Mail;
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
            string content = "";
            content += string.Format("\n\n------------------------\n");
            content += string.Format("Sent to: {0}\n\n", email.Client.Email);
            content += string.Format("Dear {0},\n\n", email.Client.Name);
            content += string.Format("Your order of {0} unit(s) of \"{1}\"\n", email.BookQuantity, email.BookTitle);
            content += string.Format("was dispatched on {0:d}, and will arrive\n", email.DispatchDate);
            content += string.Format("to {0} in the next few days.\n", email.Client.Address);
            content += string.Format("A total of {0:N} Euros have been charged to your account.\n", email.TotalPrice);
            content += string.Format("\nThank you for shopping with us.\n");
            content += string.Format("Best regards, The Management\n");
            content += string.Format("\n******Order details******\n");
            content += string.Format("{0,-15}{1}\n", "Order ID:", email.OrderID);
            content += string.Format("{0,-15}{1}\n", "Client Name:", email.Client.Name);
            content += string.Format("{0,-15}{1}\n", "Client Address:", email.Client.Address);
            content += string.Format("{0,-15}{1}\n", "Store NIF:", "123456789");
            content += string.Format("{0,-15}{1} x{2}\n", "Order:", email.BookTitle, email.BookQuantity);
            content += string.Format("{0,-15}{1:N} Euros\n", "Total Price:", email.TotalPrice);
            content += string.Format("------------------------\n");

            // Print in console.
            System.Console.WriteLine(content);

            // Send email using FEUP's smtp server.
            MailMessage mail = new MailMessage("fake@tdin.com", email.Client.Email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.fe.up.pt";
            mail.Subject = "TDIN Order Confirmation";
            mail.Body = content;
            client.Send(mail);
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