using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Payment Reminder
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        [Required]
        public string Event { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public bool Status { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
