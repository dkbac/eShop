using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Cart
    {
        public int CardID { set; get; }
        public int ProductID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public int UserID { get; set; }
        public DateTime DateCreated { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
