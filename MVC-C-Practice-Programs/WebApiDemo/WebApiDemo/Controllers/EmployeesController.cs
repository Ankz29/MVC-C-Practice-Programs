using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET api/employees

        public List<Employees> Get()
        {
            List<Employees> model = new List<Employees>();
            model.Add(new Employees { Name = "Bhavana", ID = 852 });
            model.Add(new Employees { Name = "Anisha", ID = 789 });
            model.Add(new Employees { Name = "Anish", ID = 754 });
          
            return model;
        }
        
        //    // GET api/employees/5
        //    public string Get(int id)
        //    {
        //        return "value";
        //    }

        //    // POST api/employees
        //    public void Post([FromBody]string value)
        //    {
        //    }

        //    // PUT api/employees/5
        //    public void Put(int id, [FromBody]string value)
        //    {
        //    }

        //    // DELETE api/employees/5
        //    public void Delete(int id)
        //    {
        //    }
        //}
    }
}