using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUTSurfers.Models
{
    public class Members
    {
        public int Id { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "International Student")]
        public bool IntlStudent { get; set; }

        public LevelOfSurfing SurfingLevel { get; set; }
        [Display(Name = "Level of Surfing")]
        public byte SurfingLevelId { get; set; }

        public Payment PaymentType { get; set; }
        [Display(Name = "Payment Method")]
        public byte PaymentTypeId { get; set; }

        public bool PaymentApproval { get; set; }
      
    }
}