using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassRef
{
    class Program : Interfacesample  
    {
        public string name;
        public string address;
        public static void Main(string[] args)
        {

            Program p = new Program();
            p.name = "ankz";
            p.address = "m";

            ChangeRef(p.name, p.address);
            Console.WriteLine(p.name + " " + p.address);
        }
        public static void ChangeRef(String name, String address)
        {
            name = "ankita";
            address = "mudddapur";
            Console.WriteLine("hello {0},{1}", name, address);
        }

       
    }
}
