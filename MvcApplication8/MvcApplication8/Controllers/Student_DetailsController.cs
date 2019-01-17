using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models; 

namespace MvcApplication8.Controllers
{
    public class Student_DetailsController : Controller
    {
        //
        // GET: /Student_Details/
      
        public ActionResult Index(string Contact_no)
        {
            Student_form_DBEntities sDB = new Student_form_DBEntities();
            var data = sDB.Student_form_TB.Where(t => t.Contact_no == Contact_no).ToList(); 

        
            return View(data); 
          
        }
        
    }
}
