using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [DataContract]
    public class Receipt
    {
        [DataMember]
        public string ClientName { get; set; }

        [DataMember]
        public string BookTitle { get; set; }

        [DataMember]
        public int BookQuantity { get; set; }

        [DataMember]
        public double TotalPrice { get; set; }
    }
}