using System.ServiceModel;

namespace Notifications
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(INotificationServiceCallback))]
    public interface INotificationService
    {
        [OperationContract(IsOneWay = false, IsInitiating = true)]
        void SubscribePrinter();

        [OperationContract(IsOneWay = false, IsInitiating = true)]
        void SubscribeEmailServer();

        [OperationContract(IsOneWay = false, IsInitiating = false, IsTerminating = true)]
        void UnsubscribePrinter();

        [OperationContract(IsOneWay = false, IsInitiating = false, IsTerminating = true)]
        void UnsubscribeEmailServer();
    }
}