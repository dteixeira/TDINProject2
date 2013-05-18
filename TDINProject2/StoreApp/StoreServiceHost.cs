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
        /// Starts all the hosted services.
        /// </summary>
        public void StartServices()
        {
            // Start notification services.
            if (this.NotificationService != null)
            {
                this.NotificationService.Close();
            }
            this.NotificationService = new ServiceHost(typeof(Notifications.NotificationService));
            this.NotificationService.Open();
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
        }
    }
}