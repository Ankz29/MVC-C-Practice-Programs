using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class TestApiController : ApiController
    {
        // GET api/testapi
        public IEnumerable<TestApi> Get()
        {
            TestApi ST = new TestApi();
            TestApi ST1 = new TestApi();
            List<TestApi> li = new List<TestApi>();

            ST.CarName = "Maruti Waganor";
            ST.CarPrice = "4 Lakh";
            ST.CarModel = "VXI";
            ST.CarColor = "Brown";

            ST1.CarName = "Maruti Swift";
            ST1.CarPrice = "5 Lakh";
            ST1.CarModel = "VXI";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;  
            
        }

        // GET api/testapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/testapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/testapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/testapi/5
        public void Delete(int id)
        {
        }
    }
}
