using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesMod
{
    class Employee
    {
        private int _id;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value; 
            }
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Employee ID is {0} ",e._id = 1);
           

            Console.ReadKey(); 
        }
         
    }
}
