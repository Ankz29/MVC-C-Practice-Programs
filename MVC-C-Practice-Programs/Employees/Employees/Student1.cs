using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public partial class Student :College 
    {
        private string Name;
        private int id;

        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value; 
            }
        }
        public int ID
        {
            get
            {
              return id;
            }
            set
            {
                id  = value;
            }
        }
    }
}
