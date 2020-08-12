using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service.Dto.DtoModels
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public  int ProductId { get; set; }
        [DataMember]
        public  string ProductName { get; set; }
        [DataMember]
        public  int CategoryId { get; set; }
        [DataMember]
        public  string QuantityPerUnit { get; set; }
        [DataMember]
        public  decimal UnitPrice { get; set; }
    }
}
