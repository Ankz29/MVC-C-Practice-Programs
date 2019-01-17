using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication9.Models;

namespace MvcApplication9.Controllers
{
    public class CarDetailsController : ApiController
    {
        // GET api/cardetails
        [HttpGet]
        public IEnumerable<Carstock> GetAllCarDetails()
        {
            Carstock cs = new Carstock();
            Carstock cs1 = new Carstock();
            List<Carstock> lst = new List<Carstock>();

            cs.Carname = "Maruti swift";
            cs.Carmodel = "xyz";
            cs.Carprice = 6000000;
            cs.Carcolor = "white";

            cs1.Carname = "hyundai i10";
            cs1.Carmodel = "abc";
            cs1.Carprice = 8000000;
            cs1.Carcolor = "Black";

            lst.Add(cs);
            lst.Add(cs1);

            return lst;

        }

        // GET api/cardetails/5
    
     public IEnumerable<Carstock> Get(int id)  
    {  
    Carstock cs = new Carstock();  
    Carstock cs1 = new Carstock();  
    List<Carstock> li = new List<Carstock>();  
        if (id == 1)  
        {  
            cs.Carname = "Maruti swift";
            cs.Carmodel = "xyz";
            cs.Carprice = 6000000;
            cs.Carcolor = "white";

            li.Add(cs);  
        }  
        else  
        {  
            cs1.Carname = "hyundai i10";
            cs1.Carmodel = "abc";
            cs1.Carprice = 8000000;
            cs1.Carcolor = "Black";

            li.Add(cs1);  
        }  
        return li;  
}  
        }

        // POST api/cardetails
            //[HttpPost]  
           // public void PostCar([FromBody] Carstock cs)  
            //{  
  
           // }  

        // PUT api/cardetails/5
       // public void Put(int id, [FromBody]string value)
       // {
       // }

        // DELETE api/cardetails/5
       // public void Delete(int id)
       // {
       // }
    }

