using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Lambda ld1 = new Lambda()
            {
                Name = "ankita",
                id = 001
            };
            Lambda ld2 = new Lambda()
            {
                Name = "Bhaveshwari",
                id = 002
            };
            Lambda ld3 = new Lambda()
            {
                Name = "Pushya",
                id = 003
            };
             Lambda ld4 = new Lambda()
            {
                Name = "aushya",
                id = 003
            };
            List< Lambda> lst = new List<Lambda>();
            lst.Add(ld1);
            lst.Add(ld2);
            lst.Add(ld3);
            lst.Add(ld4); 

            Console.WriteLine("The elements in list are: ");
            foreach(var v in lst)
            {
                Console.WriteLine("Name={0}, ID={1}", v.Name, v.id);
               
            }
            Lambda z = lst.Find(x=>x.Name.ToLower() == "ankita");

            int count = lst.Count(x => x.Name.StartsWith("a"));
            Console.WriteLine("count: "+ count);
            Console.ReadKey(); 
           }
    }

    public class Lambda
    {
        public string Name { get; set; }
        public int id { get; set; }
    }
}
