using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}
