using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [DataContract]
    public enum OrderState
    {
        [EnumMember]
        WaitingExpedition,

        [EnumMember]
        Dispatched,

        [EnumMember]
        FutureDispatch
    }
}
