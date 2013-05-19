using System.ServiceModel;

namespace StoreApp
{
    public class StoreServiceHost
    {
        private static StoreServiceHost instance;

        /// <summary>
        /// Instantiates a StoreServiceHost object, private to ensure
        /// singleton behavior.
        /// </summary>
        private StoreServiceHost()
        {
        }

        /// <summary>
        /// Returns the singleton instance of the class, can't be
        /// externally set.
        /// </summary>
        public static StoreServiceHost Instance
        {
            get
            {
                if (StoreServiceHost.instance == null)
                {
                    StoreServiceHost.instance = new StoreServiceHost();
                }
                return StoreServiceHost.instance;
            }
        }

        /// <summary>
        /// Notification service instance.
        /// </summary>
        private ServiceHost NotificationService { get; set; }

        /// <summary>
        /// Book store service instance.
        /// </summary>
        private ServiceHost BookStoreService { get; set; }

        /// <summary>
        /// Starts all the hosted services.
        /// </summary>
        public void StartServices()
        {
            // Start notification services.
            if (this.NotificationService != null)
            {
                this.NotificationService.Close();
            }
            if (this.BookStoreService != null)
            {
                this.BookStoreService.Close();
            }
            this.NotificationService = new ServiceHost(typeof(NotificationService.NotificationService));
            this.NotificationService.Open();
            this.BookStoreService = new ServiceHost(typeof(BookStoreService.BookStoreService));
            this.BookStoreService.Open();
        }

        /// <summary>
        /// Stops all the hosted services.
        /// </summary>
        public void StopServices()
        {
            // Stop notification services.
            if (this.NotificationService != null)
            {
                this.NotificationService.Close();
                this.NotificationService = null;
            }
            if (this.BookStoreService != null)
            {
                this.BookStoreService.Close();
                this.BookStoreService = null;
            }
        }
    }
}