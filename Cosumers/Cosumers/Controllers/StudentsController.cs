using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cosumers.Models; 


namespace Cosumers.Controllers
{
    public class StudentsController : Controller
    {
       

        public ActionResult Index()
        {
            Students s1=new Students()
            {
                sName ="ankita", id =001, std =15
            }; 
             Students s2=new Students()
            {
                sName ="anisha", id =002, std =14
            }; 
             Students s3=new Students()
            {
                sName ="pratiksha", id =003, std =13
            }; 
             Students s4=new Students()
            {
                sName ="pooja", id =004, std =12
            }; 
             Students s5=new Students()
            {
                sName ="bhaveshwari", id =005, std =11
            }; 

            
            return View();
        }

    }
}
