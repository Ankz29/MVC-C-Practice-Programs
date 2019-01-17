using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionariess
{
    class EmployeesDetails
    {
        public static void Main (string[] args)
        {
            Employee emp1 = new Employee()
            {
                EmployeeName = "Ankita",
                EmployeeId = 001,
                EmployeeSalary = 25000
            };
            Employee emp2 = new Employee()
            {
                EmployeeName = "Pavan",
                EmployeeId = 002,
                EmployeeSalary = 30000
            };
            Employee emp3 = new Employee()
            {
                EmployeeName = "Anisha",
                EmployeeId = 003,
                EmployeeSalary = 35000
            };

            Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
            dict.Add(emp1.EmployeeId, emp1);
            dict.Add(emp2.EmployeeId, emp2);
            dict.Add(emp3.EmployeeId, emp3);

            Console.WriteLine("Please enter the Employee ID:");
            int EmplID= Convert.ToInt16 (Console.ReadKey());

            ///Employeess empp= dict.Find()
        }   
                
               
           
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeSalary { get; set; }
    }
}
