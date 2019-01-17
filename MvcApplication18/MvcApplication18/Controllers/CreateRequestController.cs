using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication18.Models;
using System.Net;
using System.Text; 

namespace MvcApplication18.Controllers
{
    public class CreateRequestController : Controller
    {
        //
        // GET: /CreateRequest
        public ActionResult Index()
        {
            return View();
        }  


        //[HttpGet]
        //public ActionResult Index1()
     //   {
            //WebRequest req = WebRequest.Create(@"https://api.icims.com/customers/1255/jobs/9873?fields=jobtitle,joblocation,experienceyears,positioncategory,education,hiringmanager,duedate,enddate,startdate");
            //req.Method = "GET";
            //req.Headers["Authorization"] = "U29mdHdheUFQSToydUZhaDZDSGxYYVN0VWNo " + Convert.ToBase64String(Encoding.Default.GetBytes("SoftwayAPI:2uFah6CHlXaStUch"));
            ////req.Credentials = new NetworkCredential("username", "password");
            //HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            //return View(resp); 
        }

    }

