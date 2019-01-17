using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, " three");
            ht.Add(4, " four");

            foreach(object obj in ht )
            {
                Console.WriteLine(ht);
            }

            ht.Remove(2); 
            foreach (object obj in ht)
            {
                Console.WriteLine(ht);
            }
            ht.Clear();
            foreach (object obj in ht)
            {
                Console.WriteLine(ht);
            }




            

        }
    }
}
