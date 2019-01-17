using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employ.Models;

namespace Employ.Controllers
{
    public class EmployeesController : Controller
    {

        public ActionResult Index()
        {
            EmployeeContext empContext = new EmployeeContext();
            List<Employees> emp = empContext.Employees.ToList(); 
            return View(emp);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();

        }

    }
}
