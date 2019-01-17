using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customers.Models;

namespace Customers.Controllers
{
    public class CustomersController : Controller
    {
          public ActionResult CustomDetails()
        {
            Customer c = new Customer()
            {
                Name = "Anusha",
                LastName = "Patil",
                age = 23
            };
            return View(c);
        }

    }
}
