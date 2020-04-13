using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ClinicInfoManager.Models
{
    public class Signup
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string ClincAdminstratorFirstName { get; set; }


        [Required]
        [StringLength(255)]
        public string ClincAdminstratorLastName { get; set; }


        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(255)]
        public string UserName { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        public string ConfirmPassword { get; set; }


        [Required]
        public List<string> Country { get; set; }


        public List<string> City { get; set; }


        public List<string> DetailedAdress { get; set; }


        public string PhoneNumber { get; set; }


        public string Website { get; set; }


        [Required]
        public string membershipType { get; set; }

    }
}