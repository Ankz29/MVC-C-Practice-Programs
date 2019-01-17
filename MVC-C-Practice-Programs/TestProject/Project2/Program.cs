using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        int a, b;
        public static void Main(String[] args)
        {
             Program p = new Program();
            p.a = 3;
            p.b = 4;

            int c = p.a + p.b   ; //7
            Console.WriteLine(c);
           
            Add(p.a, p.b);
            Console.WriteLine(c);
        }


        static void  Add(int a, int b)
        {
            a = 5; b = 4; 
            int c = a + b; //9
            Console.WriteLine(c);
        }
   
        }
      
}
