using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcWebApplication.Models;
using System.Web.Mvc; 

namespace MvcWebApplication.Controllers
{
    public class ApiDemoController : Controller
    {
        public JsonResult Get()
        {
            List<ApiDemo> api = new List<ApiDemo>();
               api.Add(new ApiDemo 
               {
                   Name="Ankita",
                   Surname="Muddapur",
                   EmailId="ankita.muddapur@gmail.com"
               });
             api.Add(new ApiDemo
                 {
                     Name="Bhaveshwari",
                     Surname="Bhambar",
                     EmailId="bhaveshwaribhambar@gmail.com"
                 });
            api.Add(new ApiDemo 
                {
                    Name="Anisha",
                    Surname="Bhosale",
                    EmailId="anishabhosale@gmail.com"
                });
            api.Add(new ApiDemo 
                {
                    Name="Wricha",
                    Surname="Kashyap",
                    EmailId="wrichakashyap@gmail.com"
                }); 
            
            ResponseModel resp=new ResponseModel();
            resp.ModelData = api;
            resp.Status=200;
            resp.Message="Data retrived successfully"; 
           
             return Json(resp, JsonRequestBehavior.AllowGet);
           }
           

        }

        
    }

