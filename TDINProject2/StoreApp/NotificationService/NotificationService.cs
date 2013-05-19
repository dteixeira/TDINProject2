using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace NotificationService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class NotificationService : INotificationService
    {
        private static NotificationService instance = null;

        /// <summary>
        /// Instantiates a new NotificationService instance.
        /// </summary>
        public NotificationService()
        {
            // Instantiates the singleton object.
            if (NotificationService.instance == null)
            {
                NotificationService.instance = this;
            }

            // Creates a new client list;
            this.Printers = new List<OperationContext>();
            this.EmailServers = new List<OperationContext>();
        }

        /// <summary>
        /// Returns the singleton instance of NotificationService.
        /// </summary>
        public static NotificationService Instance
        {
            get
            {
                if (NotificationService.instance == null)
                {
                    NotificationService.instance = new NotificationService();
                }
                return NotificationService.instance;
            }
            set { NotificationService.instance = value; }
        }

        /// <summary>
        /// Returns the registered printers list.
        /// </summary>
        public List<OperationContext> Printers { get; set; }

        /// <summary>
        /// Returns the registered email servers list.
        /// </summary>
        public List<OperationContext> EmailServers { get; set; }

        /// <summary>
        /// Notifies all registered printers that a receipt should be printed.
        /// </summary>
        /// <param name="receipt">Receipt to print</param>
        public void NotifyPrinters(ServiceDataTypes.Receipt receipt)
        {
            lock (this.Printers)
            {
                for (int i = this.Printers.Count() - 1; i >= 0; i--)
                {
                    try
                    {
                        OperationContext context = this.Printers.ElementAt(i);
                        INotificationServiceCallback callback = context.GetCallbackChannel<INotificationServiceCallback>();
                        callback.PrintReceipt(receipt);
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                        this.Printers.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Notifies all registered email servers that an email should be sent.
        /// </summary>
        /// <param name="receipt">Email to send</param>
        public void NotifyEmailServers(ServiceDataTypes.Email email)
        {
            lock (this.EmailServers)
            {
                for (int i = this.EmailServers.Count() - 1; i >= 0; i--)
                {
                    try
                    {
                        OperationContext context = this.EmailServers.ElementAt(i);
                        INotificationServiceCallback callback = context.GetCallbackChannel<INotificationServiceCallback>();
                        callback.SendEmail(email);
                    }
                    catch (System.Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                        this.EmailServers.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Subscribe a new printer client.
        /// </summary>
        public void SubscribePrinter()
        {
            lock (this.Printers)
            {
                OperationContext context = OperationContext.Current;
                this.Printers.Add(context);
            }
        }

        /// <summary>
        /// Subscribe a new email server client.
        /// </summary>
        public void SubscribeEmailServer()
        {
            lock (this.EmailServers)
            {
                OperationContext context = OperationContext.Current;
                this.EmailServers.Add(context);
            }
        }

        /// <summary>
        /// Unsubscribe a printer client.
        /// </summary>
        public void UnsubscribePrinter()
        {
            lock (this.Printers)
            {
                OperationContext context = OperationContext.Current;
                OperationContext toRemove = this.Printers.FirstOrDefault(p => p.SessionId == context.SessionId);
                if (toRemove != null)
                {
                    this.Printers.Remove(toRemove);
                }
            }
        }

        /// <summary>
        /// Unsubscribe an email server client.
        /// </summary>
        public void UnsubscribeEmailServer()
        {
            lock (this.EmailServers)
            {
                OperationContext context = OperationContext.Current;
                OperationContext toRemove = this.EmailServers.FirstOrDefault(p => p.SessionId == context.SessionId);
                if (toRemove != null)
                {
                    this.EmailServers.Remove(toRemove);
                }
            }
        }
    }
}