using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication8.Models
{
    public class Student_form
    {
        [Required(ErrorMessage = "Name Required *")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name Required *")]
        public string Surname { get; set; } 

        public string Gender { get; set; }

        [Required(ErrorMessage = "Name Required *")]
        public string Contact_no { get; set; }

        [Required(ErrorMessage = "Name Required *")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name Required *")]
        public double Percentage { get; set; }

        public string Attach_File { get; set; }
    }
}