using System.ServiceModel;
using System.Collections.Generic;
using ServiceDataTypes;

namespace BookStoreService
{
    [ServiceContract]
    public interface IBookStoreService
    {
        [OperationContract]
        List<Stock> GetStock();

        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        List<Order> GetAllOrders();

        [OperationContract]
        bool UpdateOrderState(Order order);

        [OperationContract]
        bool SendDelivery(Delivery delivery);

        [OperationContract]
        Order CreateOrder(Order order);

        [OperationContract]
        List<Order> GetAllOrdersByEmail(string email);
    }
}
