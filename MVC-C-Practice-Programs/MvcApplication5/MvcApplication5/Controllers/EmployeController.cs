using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication5.Models; 

namespace MvcApplication5.Controllers
{
    public class EmployeController : Controller
    {
        //
        // GET: /Employe/

        public ActionResult Index()
        {
            Employe emp = new Employe()
            {
                Name = "Ankita",
                Email = "muddapurankita29@gmail.com",
                Contact = 1234567890
            }; 
            return View(emp);
        }

    }
}
