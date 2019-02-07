using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUTSurfers.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        [StringLength(255)]
        public string MemberName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string  Phone { get; set; }

        public string DietRequirements { get; set; }

        public string MedConditions { get; set; }
    }
}