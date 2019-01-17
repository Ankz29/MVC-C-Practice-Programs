using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSamp
{
     public delegate void HelloDelegate(string message); 

    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.Hello("hello"); 
            HelloDelegate hd=new HelloDelegate(s.Hello); 
            hd("hello delegate ");
            Console.ReadKey(); 
        }

        
    }

    class Sample
    {
        
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
        
    }
}

