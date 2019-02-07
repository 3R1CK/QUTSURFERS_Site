using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QUTSurfers.Models;
using System.ComponentModel.DataAnnotations;

namespace QUTSurfers.ViewModels
{
    public class MemberFormViewModel
    {

       
        public IEnumerable<LevelOfSurfing> LevelOfSurfing { get; set; }

        public IEnumerable<Payment> PaymentType { get; set; }

        public Members Student { get; set; }
    }
}