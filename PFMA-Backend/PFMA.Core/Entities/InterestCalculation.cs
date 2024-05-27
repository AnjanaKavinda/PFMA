using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Interest Calculation
    public class InterestCalculation
    {
        [Key]
        public int CalculationId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public double IntrestRate { get; set; }

        [Required]
        public float Duration{ get; set; } 

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
