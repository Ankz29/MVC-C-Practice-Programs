using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            List<Customer_TB> t = new List<Customer_TB>();

            Customer_DBEntities1 c = new Customer_DBEntities1();

            t = c.Customer_TB.ToList();

            return View(t);
        }

    }
}
