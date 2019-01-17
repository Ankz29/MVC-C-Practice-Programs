using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication14.Models 
{
    public class Custom
    {

        public class SearchResult
        {
            public string portalUrl { get; set; }
            public string self { get; set; }
            public int id { get; set; }
            public string updatedDate { get; set; }
        }

        public class RootObject
        {
            public List<SearchResult> searchResults { get; set; }
        }
    }
}




