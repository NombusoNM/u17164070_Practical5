using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nombusoStudyGroup.Models
{
	public class PersonModel
	{
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }
        
        [Display(Name = "First Name")]
        public string Name { get; set; }
        
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

     

        public PersonModel()
        {

        }
    }
}