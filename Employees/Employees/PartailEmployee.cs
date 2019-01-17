using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public partial  class PartailEmployee
    {
        private string empFirst_name;
        private string empLast_name;
        private int emp_id;

        public string FirstName
        {
            get
            {
                return empFirst_name;
            }
            set
            {
                empFirst_name = value; 
            }
        }
        public string LastName
        {
            get
            {
                return empLast_name;
            }
            set
            {
                empLast_name = value; 
            }
        }
        public int Emp_iD
        {
            get 
            {
                return emp_id;
            }
            set{
                emp_id =value; 
            }
        }

        public string GetFullDetails()
        {
            FirstName = "ankita";
            LastName = "Muddapur";
            emp_id = 01;
            return ("EmpName= "+empFirst_name +" EmpLastName= "+empLast_name+" Emp_ID= "+emp_id);

        }
       
       

    }
}
