using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models;

namespace MvcApplication8.Controllers
{
    public class Student_InfoController : Controller
    {
        //
        // GET: /Student_Info/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            Student_form_DBEntities sDB = new Student_form_DBEntities();
            var data = sDB.Student_form_TB.ToList();
            return View(data); 
        }
    }
}
