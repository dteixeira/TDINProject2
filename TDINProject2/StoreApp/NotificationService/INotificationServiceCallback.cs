using System.ServiceModel;

namespace Notifications
{
    public interface INotificationServiceCallback
    {
        [OperationContract]
        void PrintReceipt(ServiceDataTypes.Receipt receipt);

        [OperationContract]
        void SendEmail(ServiceDataTypes.Email email);
    }
}