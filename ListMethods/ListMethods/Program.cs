using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
   class ListMethods
    {
        public static void Main(string[] args)
        {
            List<String > lst = new List<string >();
            lst.Add("ankita");
            lst.Add("bhaveshwari");
            lst.Add("anisha");
            lst.Add("rachana");
            lst.Add("richa"); 

            foreach(string g in lst)
            {
                Console.WriteLine("Girls name: " + g); 
            }
            Console.WriteLine("<------------------------------>"); 

            lst.Insert(3, "Anusha");
            foreach(string s in lst)
            {
                Console.WriteLine("After insertion: " + s); 
            }
            Console.WriteLine("<------------------------------>"); 
            lst.Remove("ankita");
            foreach(string a in lst)
            {
                Console.WriteLine("after removing: " + a); 
            }
            Console.WriteLine("<------------------------------>");
            lst.RemoveAll(x => x.Contains("sha"));

            foreach (string a in lst)
            {
                Console.WriteLine("after removing: " + a);
            }
            //
            Console.WriteLine("<------------------------------>");
            lst.Sort();

            foreach (string a in lst)
            {
                Console.WriteLine("after sorting: " + a);
            }// 
            Console.WriteLine("<------------------------------>");
            lst.Reverse();

            foreach (string a in lst)
            {
                Console.WriteLine("after reversing : " + a);
            }

            Console.Re
        }
 
    }
}
