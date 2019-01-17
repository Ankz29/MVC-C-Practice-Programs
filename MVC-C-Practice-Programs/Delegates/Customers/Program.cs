using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    class Program
    {
        class Customer
        {
            public static void main(string[] args)
            {
                Customr c1 = new Customr()
                {
                    name = "ankita",
                    no = 006
                };
                Customr c2 = new Customr()
                {
                    name = "anisha",
                    no = 008
                };

                List<Customr> lst = new List<Customr>();
                lst.Add(c1);
                lst.Add(c2);

             /*  foreach (object o in lst)
                {
                    Console.WriteLine("Name={0}, no={1}", o.name, o.no);
                    Console.ReadKey();
                } */
                if(lst.Contains(c2))
                {
                    Console.WriteLine("exists");
                }
                else 
                {
                    Console.WriteLine("doest not exists"); 
                }

            }
        }


        public class Customr
        {
            public string name { get; set; }
            public int no { get; set; }
        }

    }

}
