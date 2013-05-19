using System.ServiceModel;
using System.Linq;

namespace BookStoreService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BookStoreService : IBookStoreService
    {
        /// <summary>
        /// Get a list with all the stock information for the store.
        /// </summary>
        /// <returns>List of stock information</returns>
        public System.Collections.Generic.List<ServiceDataTypes.Stock> GetStock()
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    return (
                        from s in context.Stocks.AsEnumerable()
                        let stock = this.GetStockByID(s.StockID)
                        where stock != null
                        select stock
                    ).ToList<ServiceDataTypes.Stock>();
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Get a list of all books that the store sells, despite
        /// being or not in stock.
        /// </summary>
        /// <returns>List of all books</returns>
        public System.Collections.Generic.List<ServiceDataTypes.Book> GetAllBooks()
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    return (
                        from b in context.Books.AsEnumerable()
                        let book = this.GetBookByID(b.BookID)
                        where book != null
                        select book
                    ).ToList<ServiceDataTypes.Book>();
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Gets a list of all the orders that the store processed,
        /// even already finished ones.
        /// </summary>
        /// <returns>List of all orders</returns>
        public System.Collections.Generic.List<ServiceDataTypes.Order> GetAllOrders()
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    return (
                        from o in context.Orders.AsEnumerable()
                        let order = this.GetOrderByID(o.OrderID)
                        where order != null
                        select order
                    ).ToList<ServiceDataTypes.Order>();
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Updates the state of an order.
        /// </summary>
        /// <param name="order">Order to update</param>
        /// <returns>True if the state is updated successfully, False otherwise.</returns>
        public bool UpdateOrderState(ServiceDataTypes.Order order)
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    var updated = context.Orders.FirstOrDefault(o => o.OrderID == order.OrderID);
                    updated.State = order.State.ToString();
                    updated.ExpDate = order.ExpDate;
                    context.SubmitChanges();
                    return true;
                }
            }
            catch (System.Exception)
            {
                // Return false if anything goes wrong.
                return false;
            }
        }

        /// <summary>
        /// Sends a new delivery of stock to the store.
        /// </summary>
        /// <param name="stock">Delivery information</param>
        /// <returns>True if success, False otherwise</returns>
        public bool SendStock(ServiceDataTypes.Stock stock)
        {
            try
            {
                var deliver = StoreApp.StoreManager.Instance.WarehouseDelivery;
                var s = deliver.FirstOrDefault(f => f.Book.BookID == stock.Book.BookID);
                if (s != null)
                {
                    s.Copies += stock.Copies;
                }
                else
                {
                    deliver.Add(stock);
                }

                // Nofity reception of stock.
                StoreApp.StoreManager.Instance.NotifyStockReceived();
                return true;
            }
            catch (System.Exception)
            {
                // Return false if anything goes wrong.
                return false;
            }
        }

        /// <summary>
        /// Creates a new order on the store server.
        /// </summary>
        /// <param name="order">Order to be created</param>
        /// <returns>The created order on success, null otherwise.</returns>
        public ServiceDataTypes.Order CreateOrder(ServiceDataTypes.Order order)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets all orders of a client, by its email.
        /// </summary>
        /// <param name="email">Client email</param>
        /// <returns>List of all orders of the client.</returns>
        public System.Collections.Generic.List<ServiceDataTypes.Order> GetAllOrdersByEmail(string email)
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    return (
                        from o in (
                            from o1 in context.Orders
                            where System.String.Compare(o1.Email, email, true) == 0
                            select o1
                        ).AsEnumerable()
                        let order = this.GetOrderByID(o.OrderID)
                        where order != null
                        select order
                    ).ToList<ServiceDataTypes.Order>();
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Gets an order by its ID.
        /// </summary>
        /// <param name="orderID">Order's ID</param>
        /// <returns>The order on success, null otherwise.</returns>
        public ServiceDataTypes.Order GetOrderByID(System.Guid orderID)
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    var order = context.Orders.FirstOrDefault(o => o.OrderID == orderID);
                    return new ServiceDataTypes.Order
                    {
                        Book = this.GetBookByID(order.BookID),
                        Client = new ServiceDataTypes.Client { Email = order.Email, Name = order.Name },
                        ExpDate = order.ExpDate,
                        Quantity = order.Quantity,
                        State = (ServiceDataTypes.OrderState)System.Enum.Parse(typeof(ServiceDataTypes.OrderState), order.State)
                    };
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Gets a book by its ID.
        /// </summary>
        /// <param name="orderID">Book's ID</param>
        /// <returns>The book on success, null otherwise.</returns>
        public ServiceDataTypes.Book GetBookByID(int bookID)
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    var book = context.Books.FirstOrDefault(b => b.BookID == bookID);
                    return new ServiceDataTypes.Book
                    {
                        Author = book.Author,
                        Price = book.Price,
                        Title = book.Title
                    };
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }

        /// <summary>
        /// Gets stock info by its ID.
        /// </summary>
        /// <param name="orderID">Stock's ID</param>
        /// <returns>The stock info on success, null otherwise.</returns>
        public ServiceDataTypes.Stock GetStockByID(int stockID)
        {
            try
            {
                using (StoreApp.StoreDataClassesDataContext context = new StoreApp.StoreDataClassesDataContext())
                {
                    var stock = context.Stocks.FirstOrDefault(s => s.StockID == stockID);
                    return new ServiceDataTypes.Stock
                    {
                        Book = this.GetBookByID(stock.BookID),
                        Copies = stock.Copies
                    };
                }
            }
            catch (System.Exception)
            {
                // Return null if anything goes wrong.
                return null;
            }
        }
    }
}
