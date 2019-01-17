using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>()
          {
              "India",
              "USA",
              "UK",
              "China"
          };
            return View();
        }

    }
}
