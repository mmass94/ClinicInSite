using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ClinicInfoManager.Models
{
    public class AppoaintmentDetails
    {
        [Required]
        public int PatientId { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public DateTime AppoaintmentDate { get; set; }
        [Required]
        public DateTime AppoaintmentTime { get; set; }
        [Required]
        public string AppoaintmentStatus { get; set; }
        [Required]
        public string VisitType { get; set; }
        [Required]
        public string DoctorName { get; set; }





    }
}