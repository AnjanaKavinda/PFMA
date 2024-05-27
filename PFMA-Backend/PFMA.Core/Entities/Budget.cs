using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Budget Management
    public class Budget
    {
        [Key]
        public int BudgetId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Limit { get; set; }

        [Required]
        public decimal Spent { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
