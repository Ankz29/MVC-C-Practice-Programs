using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLib
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer custom = new Customer();
            {
                name = "ankita",
                Id = 02
            }; 
        }
    }

    public class Customer
    {
        public string name { get; set;}
        public int Id{get; set;}
    }
}
