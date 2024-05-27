using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Budget Alerts
    public class BudgetAlert
    {
        [Key]
        public int AlertId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Frequency { get; set; } 

        public TimeOnly Time { get; set; }
        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
