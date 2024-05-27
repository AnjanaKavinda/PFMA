using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Savings and Goal Tracking
    public class SavingsAccount
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public string GoalName { get; set; }

        [Required]
        public decimal TargetAmount { get; set; }

        [Required]
        public DateTime TargetDate { get; set; }
        public float Savings { get; set; } 

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
