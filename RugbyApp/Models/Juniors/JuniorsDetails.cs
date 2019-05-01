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
        [Required]
        [Display(Name = "Member Forename")]
        public string FName { get; set; }
        [Required]
        [Display(Name = "Member Surname")]
        public string LName { get; set; }
        [Required]
        [Display(Name = "Member DOB")]
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name = "Member Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Member Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Member Email")]
        public string Email { get; set; }
    }
}