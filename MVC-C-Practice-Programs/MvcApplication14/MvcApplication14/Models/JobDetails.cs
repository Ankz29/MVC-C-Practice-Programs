using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication14.Models
{
    public class JobDetails
    {

        public class Hiringmanager
        {
            public string profile { get; set; }
            public int id { get; set; }
            public string value { get; set; }
        }

        public class Positioncategory
        {
            public string id { get; set; }
            public string formattedvalue { get; set; }
            public string soccode { get; set; }
            public string value { get; set; }
        }

        public class Link
        {
            public string rel { get; set; }
            public string title { get; set; }
            public string url { get; set; }
        }

        public class Joblocation
        {
            public int companyid { get; set; }
            public string address { get; set; }
            public int id { get; set; }
            public string value { get; set; }
        }

        public class RootObject
        {
            public string jobtitle { get; set; }
            public Hiringmanager hiringmanager { get; set; }
            public Positioncategory positioncategory { get; set; }
            public List<Link> links { get; set; }
            public Joblocation joblocation { get; set; }
        }
    }
}