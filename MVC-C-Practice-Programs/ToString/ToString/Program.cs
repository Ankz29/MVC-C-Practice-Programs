using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c = new Customer();
            c.FirstName("Ankita");
            c.LastName("Muddapur");

            Console.WriteLine(Convert.ToString(c)); 
        }
    }


    class Customer
    {
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return this.FirstName + "," + this.LastName; 
        }
    }
}
