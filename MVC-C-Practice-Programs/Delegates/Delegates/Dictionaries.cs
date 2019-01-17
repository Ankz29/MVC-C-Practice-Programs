using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Dictionaries
    {
        public static void main(string[] args)
        {
            Customer c1 = new Customer
            {
                Name = "Ankita",
                Id = 003
            };

            Customer c2 = new Customer
            {
                Name = "anisha",
                Id = 004
            };

            Dictionary<c1.Id, Customer> dict = new Dictionary<c1.Id, Customer>(); 


        }

    }

    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set;}
    }
}
