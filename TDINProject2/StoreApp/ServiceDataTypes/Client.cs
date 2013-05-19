using System;
using System.Runtime.Serialization;

namespace ServiceDataTypes
{
    [Serializable]
    [DataContract]
    public class Client
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
