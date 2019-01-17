using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication6.Models
{
    public class People
    {
       [Required(ErrorMessage ="Name should not exceed the limit")]
        public string Name { get; set; }
        
       [Required(ErrorMessage ="please fill in existing mail iD")]
       public string Email { get; set; }
        public string Gender { get; set;  }
       
        public long Contact { get; set; }
        public string Physically_abled { get; set; }
    }
}