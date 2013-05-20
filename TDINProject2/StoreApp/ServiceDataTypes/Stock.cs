using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Stock
    {
        [DataMember]
        public int StockID { get; set; }

        [DataMember]
        public Book Book { get; set; }

        [DataMember]
        public int Copies { get; set; }
    }
}
