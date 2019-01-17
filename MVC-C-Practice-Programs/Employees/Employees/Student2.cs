using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public partial  class Student : College
    {

       public string FullDetails()
       {
           
           NAME = "ANKITA";
           ID = 01;
           string msg = " Name: " + NAME +"\n "+" Id: " + ID;
           return (msg + "\n"+" college Name: " + base.CollName);  
       }

       public static void Main(string[] args)
       {
           
           Student s = new Student();
           Console.WriteLine(s.FullDetails());
           Console.ReadKey(); 


       }
    }
}
