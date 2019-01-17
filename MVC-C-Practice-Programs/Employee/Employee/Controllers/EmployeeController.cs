using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employe.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        {
            Emp emp = new Emp()
            {
                empId = 01,
                empName = "Ankita Muddapur",
                Gender = "Female",
                salary = 25000
            }; 
            return View(emp);
        }

    }
}
