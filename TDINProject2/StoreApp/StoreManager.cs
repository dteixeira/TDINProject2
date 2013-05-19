using System;
using System.Collections.Generic;

namespace StoreApp
{
    public class StoreManager
    {
        private static StoreManager instance = new StoreManager();

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

        public List<ServiceDataTypes.Stock> WarehouseDelivery { get; private set; }

        /* Event registration and handling */

        public delegate void StockReceivedHandler();
        public delegate void OrderReceivedHandler();
        public event StockReceivedHandler StockReceivedEvent;
        public event OrderReceivedHandler OrderReceivedEvent;

        /// <summary>
        /// Creates a new StoreManager instance, private to
        /// ensure singleton behavior.
        /// </summary>
        private StoreManager()
        {
            this.WarehouseDelivery = new List<ServiceDataTypes.Stock>();
        }

        /// <summary>
        /// Notifies all registered clients that a delivery from
        /// the warehouse was received.
        /// </summary>
        public void NotifyStockReceived()
        {
            if (this.StockReceivedEvent != null)
            {
                Delegate[] invokeList = this.StockReceivedEvent.GetInvocationList();
                foreach (StockReceivedHandler handler in invokeList)
                {
                    try
                    {
                        IAsyncResult ar = handler.BeginInvoke(null, null);
                    }
                    catch (Exception)
                    {
                        this.StockReceivedEvent -= handler;
                    }
                }
            }
        }

        /// <summary>
        /// Notifies all registered clients that a new
        /// order was received.
        /// </summary>
        public void NotifyOrderReceived()
        {
            if (this.OrderReceivedEvent != null)
            {
                Delegate[] invokeList = this.OrderReceivedEvent.GetInvocationList();
                foreach (OrderReceivedHandler handler in invokeList)
                {
                    try
                    {
                        IAsyncResult ar = handler.BeginInvoke(null, null);
                    }
                    catch (Exception)
                    {
                        this.OrderReceivedEvent -= handler;
                    }
                }
            }
        }
    }
}