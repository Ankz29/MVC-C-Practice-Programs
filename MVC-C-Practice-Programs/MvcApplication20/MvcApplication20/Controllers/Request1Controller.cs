using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication20.Models;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json; 

namespace MvcApplication20.Controllers
{
    public class Request1Controller : Controller
    {
        //
        // GET: /Request1/

        public ActionResult Index()
        {
            WebRequest req = WebRequest.Create(@"https://api.icims.com/customers/1255/v2/lists/lists.country/D41001?size=1000"); 

            req.Method = "GET";
            req.Headers["Authorization"] = "Basic U29mdHdheUFQSToydUZhaDZDSGxYYVN0VWNo";
            //req.Credentials = new NetworkCredential("username", "password");


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

            var responseText = new StreamReader(resp.GetResponseStream()).ReadToEnd();
            MvcApplication20.Models.Request1.Root rootObject = JsonConvert.DeserializeObject<MvcApplication20.Models.Request1.Root>(responseText.ToString());

            return View(rootObject);
        }

    }
}
