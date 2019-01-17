using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication20.Models
{
    public class Request1
    {
        public class Self
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
        }

        public class Child
        {
            public string abv2 { get; set; }
            public bool hidden { get; set; }
            public Links _links { get; set; }
            public string id { get; set; }
            public string listnodeid { get; set; }
            public string value { get; set; }
        }

        public class Last
        {
            public string href { get; set; }
        }

        public class Self2
        {
            public string href { get; set; }
        }

        public class First
        {
            public string href { get; set; }
        }

        public class Links2
        {
            public Last last { get; set; }
            public Self2 self { get; set; }
            public First first { get; set; }
        }

        public class Root 
        {
            public string abv2 { get; set; }
            public string abv3 { get; set; }
            public bool hidden { get; set; }
            public int iso { get; set; }
            public List<Child> children { get; set; }
            public Links2 _links { get; set; }
            public string id { get; set; }
            public string listnodeid { get; set; }
            public string value { get; set; }
        }
    }
}