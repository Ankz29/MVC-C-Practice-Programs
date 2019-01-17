using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.IO; 


namespace MvcApplication8.Controllers
{
    public class Student_formController : Controller
    {
        //
        // GET: /Student_form/
        public ActionResult Index()
        {
            TempData["SuccessMessage"] = "";

            return View(); 
        }


        [HttpPost]
        public ActionResult Index(Student_form std, HttpPostedFileBase file)
        {
             TryUpdateModel(std);

            string Name=std.Name;
            string Surname=std.Surname;
            string  Gender=std.Gender;
            string Contact_no=std.Contact_no;
            string Email = std.Email;
            double Percentage = std.Percentage;
            string Attach_File = file.FileName; 


            string _FileName = Path.GetFileName(file.FileName); 
            string _path = Path.Combine(Server.MapPath(@"\upload\"), _FileName);
            file.SaveAs(_path);  

          
               
                    //string _FileName = Path.GetFileName(file.FileName);
                   // string _path = Path.Combine(Server.MapPath("~/"), _FileName);    
                   
                    // file.SaveAs(_path);     
            
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Student_form_TB (Name, Surname,Gender,Contact_no,Email,Percentage,Upload_File) VALUES('"+Name+"', '"+Surname+"','"+Gender+"','"+Contact_no+"','"+Email+"',"+Percentage+",'"+Attach_File+"')";
               
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    
                    cmd.ExecuteNonQuery(); 
                    con.Close();
                }
                TempData["SuccessMessage"] = "Data Save Successfully";
            }

            Response.Redirect("~/Student_Info/Index"); 
           
            return View();
        }

    }
}
