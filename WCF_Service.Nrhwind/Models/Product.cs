using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Service.Nrhwind
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
    }
}