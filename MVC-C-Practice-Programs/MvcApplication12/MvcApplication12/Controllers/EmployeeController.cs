using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication12.Models; 

namespace MvcApplication12.Controllers
{
    public class EmployeeController : Controller
    {
       
        // GET: /Employee/
        //[Authorize]
        [HttpPost]
        public ActionResult Index()
        {
            Console.WriteLine("welcome"); 
            return View();
        }

    }
}
