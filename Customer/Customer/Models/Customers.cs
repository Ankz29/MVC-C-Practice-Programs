using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Item_Purchased { get; set; }
        public int Item_Price { get; set; }
    }
}