using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebApplication.Models
{
    public class ApiDemo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailId { get; set; }
    }

    public class ResponseModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public Object ModelData { get; set; }
    }
}