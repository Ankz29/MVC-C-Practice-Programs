using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        static void Main(string[] args)
       {
            Emp e1 = new Emp()      //setting the properties // 
            {
                Name = "ankita",
                id = 001
            };

            Emp e2 = new Emp()
            {
                Name = "xyz",
                id = 002
            };
            Emp e3 = new Emp()
            {
                Name = "abc",
                id = 003
            }; 

            List<Emp> empp = new List<Emp>(2);
            empp.Add(e1);
            empp.Add(e2);
            empp.Add(e3);

            Emp e= empp[0];
            Console.WriteLine("Name ={0}, id= {1}", e.Name, e.id);
            Console.ReadKey(); 

        }
    }

    public class Emp
    {
        public string Name { get; set; }  //properties //
        public int id { get; set; }
    }
}
