using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication14.Models
{
    public class JobModel
    {
        public int jobId { get; set; } 
        public string jobtitle { get; set; }
        public string hiringManager { get; set; }
        public string companyAddress { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}