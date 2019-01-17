using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {

        static void ChangeString(String name)
        {
            name = "ankita";
            Console.WriteLine(name);
        }

        static void Main(String[] args)
        {

            String name = "ankz";
            Console.WriteLine(name);

            ChangeString(name);
            Console.WriteLine(name);
        }
    }

}
    

