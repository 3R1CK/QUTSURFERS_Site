using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QUTSurfers.Models
{
    public class LevelOfSurfing
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
        
    }
}