using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [DataContract]
    public class Email
    {
        [DataMember]
        public string OrderID { get; set; }

        [DataMember]
        public string ClientName { get; set; }

        [DataMember]
        public string ClientEmail { get; set; }

        [DataMember]
        public string BookTitle { get; set; }

        [DataMember]
        public int BookQuantity { get; set; }

        [DataMember]
        public double TotalPrice { get; set; }

        [DataMember]
        public System.DateTime DispatchDate { get; set; }
    }
}
