using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Cart> Carts { get; set; }
    }
}
