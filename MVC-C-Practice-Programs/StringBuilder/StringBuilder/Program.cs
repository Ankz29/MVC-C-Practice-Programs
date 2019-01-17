using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strng
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder s = new StringBuilder("C#");
            s.Append(" tutor's");
            s.Append(" beginners");
            s.Append(" freshers");

            Console.WriteLine(s);
            Console.ReadKey(); 
        }
    }
}
