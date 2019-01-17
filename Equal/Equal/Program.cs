using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "ankita";
            c1.LastName = "Muddapur";

            Customer c2 = c1; 
            

            Customer c3 = new Customer();
            c3.FirstName = "ankit";
            c3.LastName = "M";

            Console.WriteLine(c1 == c2);
            // Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c3));
            Console.ReadKey(); 
        }
    }


    class Customer
    {
        public string FirstName;
        public string LastName;

        public override bool Equals(object obj)
        {
           if(obj==null )
           {
               return false;
           }
            if(!(obj is Customer) )
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
           
        } 
        } 
    }
