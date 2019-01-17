using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class Departmnts
    {
        [Table("tblDepartment")]
        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public List<Employee> Employees { get; set; }
        }
    }
}