using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication14.Models
{
    public class JobInfo
    {
        public class Addressstate
        {
            public string id { get; set; }
            public string abbrev { get; set; }
            public string value { get; set; }
        }

        public class Addresscountry
        {
            public string id { get; set; }
            public string abbrev { get; set; }
            public string value { get; set; }
        }

        public class RootObject
        {
            public string addresscity { get; set; }
            public string addresszip { get; set; }
            public Addressstate addressstate { get; set; }
            public Addresscountry addresscountry { get; set; }
            public string addressstreet1 { get; set; }
        }
    }

}