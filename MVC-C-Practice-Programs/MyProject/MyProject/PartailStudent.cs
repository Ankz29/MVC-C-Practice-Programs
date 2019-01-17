using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public partial class PartialStudent : School
    {
        

        public string StudentsName { get; set; }
        public int StudentsRollNo { get; set; }

        

        public static void Main(string[] args)
        {

            
              List<PartialStudent> lst = new List<PartialStudent>
            {
                new PartialStudent() { StudentsName = "Priyanka", StudentsRollNo = 001},
                new PartialStudent() { StudentsName = "anusha", StudentsRollNo = 002},
                new PartialStudent() { StudentsName = "Bhavana", StudentsRollNo = 003},
                new PartialStudent() { StudentsName = "Priya", StudentsRollNo = 004},
                new PartialStudent() { StudentsName = "anjali", StudentsRollNo = 005},
                new PartialStudent() { StudentsName = "Sushmita", StudentsRollNo = 006},

            };

            foreach(var v in lst)
            {
                Console.WriteLine("StudentName={0}, StudentRollNo={1}", v.StudentsName, v.StudentsRollNo);
                
            }

            Console.ReadKey(); 
        }
    }
}
