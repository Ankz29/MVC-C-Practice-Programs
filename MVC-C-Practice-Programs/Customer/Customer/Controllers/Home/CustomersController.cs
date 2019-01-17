using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer.Models;

namespace Customer.Controllers.Home
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            CustomerContext cContext = new CustomerContext();

            return View();
        }

    }
}
