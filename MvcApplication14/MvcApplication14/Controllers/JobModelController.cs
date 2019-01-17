using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication14.Models;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;

namespace MvcApplication14.Controllers
{ 
    public class JobModelController : Controller 
    {  
       // [HttpGet]
        public ActionResult Index()
        {
            //<-----Job List URL1---->//
             string JobListURL1 = ConfigurationManager.AppSettings["JobList"].ToString();

            //<----Job Details URL2----->// 
             string JobDetailsURL2 = ConfigurationManager.AppSettings["JobDetails"].ToString();
            
             string Authorization = ConfigurationManager.AppSettings["Authorization"];

            // <---------web request for URL1-------->//
             WebRequest request1 = WebRequest.Create(JobListURL1);
             request1.Headers["Authorization"] = Authorization; 
             request1.Method = "GET";
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            System.Threading.Thread.Sleep(250); 
            var response = (HttpWebResponse)request1.GetResponse();
            var responseText1 = new StreamReader(response.GetResponseStream()).ReadToEnd();
            MvcApplication14.Models.Custom.RootObject rootObject = JsonConvert.DeserializeObject<MvcApplication14.Models.Custom.RootObject>(responseText1.ToString());
            
            
            List<MvcApplication14.Models.JobModel> listmodel = new List<MvcApplication14.Models.JobModel>();
            foreach (var item in rootObject.searchResults)
            {

                // <---------- web request for URL2->//
                HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(JobDetailsURL2 + item.id + "?fields=jobtitle,joblocation,experienceyears,positioncategory,education,hiringmanager,duedate,enddate,startdate");
                request2.Method = "GET";
                request2.Accept = "application/json; charset=utf-8"; 
                request2.Headers["Authorization"] = Authorization;
                System.Threading.Thread.Sleep(250); 
                var response2 = (HttpWebResponse)request2.GetResponse();
                var responseText2 = new StreamReader(response2.GetResponseStream()).ReadToEnd();
                MvcApplication14.Models.JobDetails.RootObject rootObject1 = JsonConvert.DeserializeObject<MvcApplication14.Models.JobDetails.RootObject>(responseText2.ToString());

                // <----- web request for URL3 extracting from the second response url------> //
                HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create(rootObject1.joblocation.address);               
                request3.Method = "GET";
                request3.Accept = "application/json; charset=utf-8"; 
                request3.Headers["Authorization"] = Authorization;
                System.Threading.Thread.Sleep(250); 
                var response3 = (HttpWebResponse)request3.GetResponse();
                var responseText3 = new StreamReader(response3.GetResponseStream()).ReadToEnd();
                MvcApplication14.Models.JobInfo.RootObject rootObject2 = JsonConvert.DeserializeObject<MvcApplication14.Models.JobInfo.RootObject>(responseText3.ToString());
                //binding to the list model for displaying in view
                
                listmodel.Add(new JobModel()
                {
                    jobId = item.id == null ? 0 : item.id,
                    jobtitle = rootObject1.jobtitle== null ? "" : rootObject1.jobtitle,
                    hiringManager = rootObject1.hiringmanager.value == null ? "" : rootObject1.hiringmanager.value,
                    companyAddress = rootObject1.joblocation == null ? "" : rootObject1.joblocation.value,
                    Country = rootObject2.addresscountry== null ? "" : rootObject2.addresscountry.value,
                    State = rootObject2.addressstate == null ? "" : rootObject2.addressstate.value,
                    City = rootObject2.addresscity== null ? "" : rootObject2.addresscity
                });
               
            } 
            return View(listmodel);
        }
    }
}

