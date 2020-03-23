using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SEOAlias { get; set; }
    }
}
