using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.Stack st = new System.Collections.Stack();
            
            st.Push("a");
            st.Push("b");
            st.Push("c");
            st.Push("d");

            Console.WriteLine(" Stack Contains: ");
            foreach(object ob in st)
            {
               Console.WriteLine(st+ " ");
            }
            Console.WriteLine(st); 

        }
    }
}
