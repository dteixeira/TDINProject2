using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Stock
    {
        [DataMember]
        public Book Book { get; set; }

        [DataMember]
        public int Copies { get; set; }
    }
}
