using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Controllers;
// using WebApplication1.Mvc; //
 

namespace MvcApplication0.Controllers
{
    public class Ankita_DBEntitiesController : Controller
    {
        //
        // GET: /Ankita_DBEntities/

        public ActionResult Index()
        {
            Ankita_DBEntities aDB = new Ankita_DBEntities();
            var data = aDB.Ankita_TB.Tolist();
            return View(data);
        }
    }
}
