using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int DelegateMet(); 
    class DelegateDemo
    {
        public static void Main(string[] args)
        {
            DelegateMet dm = new DelegateMet(Add);
            dm();
            //
        }

        public static  int Add()
        {
            int sum = 0;
            for (int  i= 0; i <=5; i++)
            {
               sum= sum+ i; 
            }
            Console.WriteLine("the total sum is : "+sum);
            Console.ReadKey(); 
            return sum;
        }
        
    }
}
