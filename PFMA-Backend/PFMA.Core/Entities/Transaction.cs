using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Cash Flow Management
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public Guid DocumentID { get; set; }  

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
