using System;
using System.Collections.Generic;
using System.Messaging;

namespace StoreApp
{
    public class StoreManager
    {
        private readonly static string QueueName = @".\private$\TDINStoreWarehouseQueue";
        private static StoreManager instance;

        /* Properties */

        public static StoreManager Instance
        {
            get
            {
                if (StoreManager.instance == null)
                {
                    StoreManager.instance = new StoreManager();
                }
                return StoreManager.instance;
            }
        }

        public MessageQueue Queue { get; private set; }

        /* Event registration and handling */

        public delegate void DeliveryReceivedHandler(ServiceDataTypes.Delivery delivery);
        public delegate void OrderReceivedHandler(ServiceDataTypes.Order order);
        public delegate void OrderStateUpdatedHandler(ServiceDataTypes.Order order);
        public event DeliveryReceivedHandler DeliveryReceivedEvent;
        public event OrderReceivedHandler OrderReceivedEvent;
        public event OrderStateUpdatedHandler OrderStateUpdatedEvent;

        /// <summary>
        /// Creates a new StoreManager instance, private to
        /// ensure singleton behavior.
        /// </summary>
        private StoreManager()
        {
            try
            {
                // Creates a new queue if it doesn't exist.
                if (!MessageQueue.Exists(StoreManager.QueueName))
                {
                    MessageQueue.Create(StoreManager.QueueName);
                }

                // Connects and configures queue.
                this.Queue = new MessageQueue(StoreManager.QueueName);
                this.Queue.Formatter = new XmlMessageFormatter(new Type[] { typeof(ServiceDataTypes.Order) });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Notifies all registered clients that a delivery from
        /// the warehouse was received.
        /// </summary>
        public void NotifyDeliveryReceived(ServiceDataTypes.Delivery delivery)
        {
            if (this.DeliveryReceivedEvent != null)
            {
                Delegate[] invokeList = this.DeliveryReceivedEvent.GetInvocationList();
                foreach (DeliveryReceivedHandler handler in invokeList)
                {
                    try
                    {
                        IAsyncResult ar = handler.BeginInvoke(delivery, null, null);
                    }
                    catch (Exception)
                    {
                        this.DeliveryReceivedEvent -= handler;
                    }
                }
            }
        }

        /// <summary>
        /// Notifies all registered clients that a new
        /// order was received.
        /// </summary>
        public void NotifyOrderReceived(ServiceDataTypes.Order order)
        {
            if (this.OrderReceivedEvent != null)
            {
                Delegate[] invokeList = this.OrderReceivedEvent.GetInvocationList();
                foreach (OrderReceivedHandler handler in invokeList)
                {
                    try
                    {
                        IAsyncResult ar = handler.BeginInvoke(order, null, null);
                    }
                    catch (Exception)
                    {
                        this.OrderReceivedEvent -= handler;
                    }
                }
            }
        }

        /// <summary>
        /// Notifies all registered clients that an order was updated.
        /// </summary>
        public void NotifyOrderStateUpdated(ServiceDataTypes.Order order)
        {
            if (this.OrderReceivedEvent != null)
            {
                Delegate[] invokeList = this.OrderStateUpdatedEvent.GetInvocationList();
                foreach (OrderStateUpdatedHandler handler in invokeList)
                {
                    try
                    {
                        IAsyncResult ar = handler.BeginInvoke(order, null, null);
                    }
                    catch (Exception)
                    {
                        this.OrderStateUpdatedEvent -= handler;
                    }
                }
            }
        }
    }
}