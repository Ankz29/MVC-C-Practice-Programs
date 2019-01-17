using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string Delegatess(string Names, int ID);
    class DelegateDemp1
    {
        public string Name { get; set; }
        public int id { get; set; }

          public static void Main(string[] args)
        {

            Delegatess dgts = new Delegatess(FullDetails);
           /// dgts(); 
            DelegateDemp1 dgt1 = new DelegateDemp1();
            dgt1 = new DelegateDemp1
            {
                Name = "Ankita",
                id = 001
            };
            dgt1 = new DelegateDemp1
            {
                Name = "Bhaveshwari",
                id = 002
            };

        }

          public static string FullDetails(string Name, int id)
          {
              string FullDetail = Name + id;
              return FullDetail;
          }

    }
}

       
