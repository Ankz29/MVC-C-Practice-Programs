using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication13.Models;
using System.Net.Mail;
using System.Net;

namespace MvcApplication13.Controllers
{
    public class EmailSendController : Controller
    {

        //home httpget //
        public ActionResult Index()
        {
            return View(); 
        }
        // GET: /EmailSend/
        [HttpPost]
        public ActionResult Index(EmailSend es)
        {
            string Name = es.Name;
            string Phone_No = es.Phone_No;
            string Email = es.Email;
            var senderEmail = new MailAddress("brijesh.kumar@softwaysolutions.com");
            var receiverEmail = new MailAddress(es.Email, "Receiver");
            var password = "Leader@786";
            var sub = "Contact Us";
            var body = "Thank You for contacting us!!";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = sub,
                Body = body
            })
            {
                smtp.Send(mess);
            }  
            return View(es);
        }

    }
}
