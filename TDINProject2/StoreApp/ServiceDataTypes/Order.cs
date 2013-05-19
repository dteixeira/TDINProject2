using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Order
    {
        [DataMember]
        public System.Guid OrderID { get; set; }

        [DataMember]
        public Client Client { get; set; }

        [DataMember]
        public Book Book { get; set; }

        [DataMember]
        public OrderState State { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public System.DateTime? ExpDate { get; set; }
    }
}
