using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Program
    {
        public virtual void Method()
        {
            Console.WriteLine("I am Base Class ");
        }

        public class Derived : Program
        {
            public override void Method()
            {
                Console.WriteLine("I am Derived Class ");
            }
        }

        public static void Main()
        {
            Program p = new Derived();
             p.Method();  
        }
        

    }
}
