using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class Ankita_TBController : Controller
    {
        //
        // GET: /Ankita_TB/

        public ActionResult Index()
        {
            Ankita_DBEntities aDB = new Ankita_DBEntities();
           var data = aDB.Ankita_TB.ToList();  

            return View(data);
        }

        public ActionResult Details(int id)
        {
            Ankita_DBEntities aDB = new Ankita_DBEntities();
            var emp = aDB.Ankita_TB.Single(empp => empp.Emp_ID == id);

            return View(emp); 
        }
    }
}
