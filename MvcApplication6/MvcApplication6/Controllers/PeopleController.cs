using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class PeopleController : Controller
    {
        //
        // GET: /People/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(People people)
        {
            string Name = people.Name;
            string Email = people.Email;
            string Gender = people.Gender;
            long Contact = people.Contact;
            string Physically_abled= people.Physically_abled ;

            return View();

        }

    }
}
