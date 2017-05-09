using System;
using System.Runtime.Serialization;

namespace RepliconService.DataModel.Product
{
    [DataContract]
    public class ProductDetail
    {
        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string Rating { get; set; }
    }
}
