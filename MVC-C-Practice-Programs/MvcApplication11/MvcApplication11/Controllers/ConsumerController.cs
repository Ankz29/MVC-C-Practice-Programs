using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication11.Models; 

namespace MvcApplication11.Controllers
{
    public class ConsumerController : Controller
    {
       

        public ActionResult Index()
        {
            Consumer_DBEntities consumer_db = new Consumer_DBEntities();
            var data = consumer_db.Consumer_DB.ToList();

            return View(data); 
        }

    }
}
