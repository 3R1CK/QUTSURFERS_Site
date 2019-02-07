using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUTSurfers.Dtos
{
    public class MemberDto
    {
        public int Id { get; set; }

        public DateTime DateAdded { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string StudentNumber { get; set; }

        public bool IntlStudent { get; set; }

        public byte SurfingLevelId { get; set; }

        public LevelOfSurfingDto SurfingLevel { get; set; }

        public byte PaymentTypeId { get; set; }

        public PaymentDto PaymentType { get; set; }

        public bool PaymentApproval { get; set; }
    }
}