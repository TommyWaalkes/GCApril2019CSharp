using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class Car
    {
        [Required]
        [Key]
        [StringLength(30)]
        public String Make { get; set; }

        [StringLength(30, MinimumLength = 8)]
        public String Color { get; set; }

        [DisplayName("Miles")]
        public int Mileage { get; set; }
        public bool IsUsed { get; set; }
    }
}