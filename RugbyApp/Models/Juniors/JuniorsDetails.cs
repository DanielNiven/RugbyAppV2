using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RugbyApp.Models.Juniors
{
    public class JuniorsDetails
    {
        [Key]
        public int SruNumber { get; set; }
        [Required(ErrorMessage = "You must enter a Forename for member")]
        [Display(Name = "Member Forename")]
        public string FName { get; set; }
        [Required(ErrorMessage = "You must enter a Surname for member")]
        [Display(Name = "Member Surname")]
        public string LName { get; set; }
        [Required(ErrorMessage = "You must enter a Date of birth(DD/MM/YYYY) for member")]
        [Display(Name = "Member DOB")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "You must enter an Address for member")]
        [Display(Name = "Member Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must enter a phone number for member")]
        [Display(Name = "Member Phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "You must enter an Email address for member")]
        [Display(Name = "Member Email")]
        public string Email { get; set; }
    }
}