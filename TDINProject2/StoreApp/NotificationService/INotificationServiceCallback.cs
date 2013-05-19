using System.ServiceModel;

namespace NotificationService
{
    public interface INotificationServiceCallback
    {
        [OperationContract]
        void PrintReceipt(ServiceDataTypes.Receipt receipt);

        [OperationContract]
        void SendEmail(ServiceDataTypes.Email email);
    }
}