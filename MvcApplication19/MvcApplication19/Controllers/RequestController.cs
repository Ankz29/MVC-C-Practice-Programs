using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication19.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json; 

namespace MvcApplication19.Controllers
{
    public class RequestController : Controller
    { 
        //
        // GET: /Request/

        public ActionResult Index()
        {
            WebRequest req = WebRequest.Create(@"https://api.icims.com/customers/1255/jobs/9873?fields=jobtitle,joblocation,experienceyears,positioncategory,education,hiringmanager,duedate,enddate,startdate");
            req.Method = "GET";
            req.Headers["Authorization"] = "Basic U29mdHdheUFQSToydUZhaDZDSGxYYVN0VWNo"; 
            //req.Credentials = new NetworkCredential("username", "password");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
           
            var responseText = new StreamReader(resp.GetResponseStream()).ReadToEnd();
            MvcApplication19.Models.Request.RootObject rootObject = JsonConvert.DeserializeObject<MvcApplication19.Models.Request.RootObject>(responseText.ToString());

            return View(rootObject);
        }

    }
}
