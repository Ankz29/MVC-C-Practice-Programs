using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class EmpDetailsController : Controller
    {
        //
        // GET: /EmpDetails/

        public ActionResult Index()
        {
            EmployeeDBEntities dbcontext = new EmployeeDBEntities();
           var data= dbcontext.Emp_TB.ToList();
            return View(data);
        }

    }
}
