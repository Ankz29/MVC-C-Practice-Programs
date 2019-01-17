using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication17.Models;
using System.Net;
using System.Text;
using System.Net.Http; 

namespace MvcApplication17.Controllers
{
    public class RequestController : Controller
    {
        // GET: /Api
        //Home// 
        public ActionResult Index()
        {
            return View(); 
        }

     //   public ActionResult Index1(Request api)
    //    {
           // string Name = api.Name; 
         //   return View(Name); 
       // }

    //    public ActionResult Getapi()
    //    {
    ////        using (var client = new HttpClient())
    ////    {
    ////    var url = "https://api.icims.com/customers/1255/jobs/9873?fields=jobtitle,joblocation,experienceyears,positioncategory,education,hiringmanager,duedate,enddate,startdate";
    ////client.DefaultRequestHeaders.Add("Authorization", "Basic U29mdHdheUFQSToydUZhaDZDSGxYYVN0VWNo ");
    ////var response = client.GetStringAsync(url);
    ////// Parse JSON response.

    ////return View();
    ////        }
    //        WebRequest req = WebRequest.Create(@"https://api.icims.com/customers/1255/jobs/9873?fields=jobtitle,joblocation,experienceyears,positioncategory,education,hiringmanager,duedate,enddate,startdate");
    //        req.Method = "GET";
    //        req.Headers["Authorization"] = "U29mdHdheUFQSToydUZhaDZDSGxYYVN0VWNo";
    //        //req.Credentials = new NetworkCredential("username", "password");
    //        HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
    //        return View(resp);
    //    }

    }
}
