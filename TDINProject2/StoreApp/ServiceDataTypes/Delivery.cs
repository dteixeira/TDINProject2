using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Delivery
    {
        [DataMember]
        public int DeliveryID { get; set; }

        [DataMember]
        public Order Order { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public bool Accepted { get; set; }
    }
}
