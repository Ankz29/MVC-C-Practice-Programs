using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index()
        {
            Employees_DBEntities edb = new Employees_DBEntities();
            var data=edb.Employees_TB.ToList();

            return View(data);
        }

    }
}
