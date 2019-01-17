using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication21.Models;
namespace MvcApplication21.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/customers
      public List<Customers> Get()
        {
            List<Customers> model = new List<Customers>();
            model.Add(new Customers { Name = "ANKITA", age = 25, Email = "ankita@gmail.com" });
            model.Add(new Customers { Name = "BHAVANA", age = 25, Email = "bhavana@gmail.com" });
            model.Add(new Customers { Name = "DANIEL", age = 25, Email = "daneil@gmail.com" });

            return model;
        }

        //// GET api/customers/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/customers
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/customers/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/customers/5
        //public void Delete(int id)
        //{
        //}
    }
}
