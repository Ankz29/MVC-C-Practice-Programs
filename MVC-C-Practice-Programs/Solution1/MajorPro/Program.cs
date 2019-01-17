using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age <= 18)
            {
                Console.WriteLine("minor");
                Console.ReadKey();
            }
            else if(age>=18)
            {
                Console.WriteLine("major");
                Console.ReadKey();
            }

    }
    }
}
