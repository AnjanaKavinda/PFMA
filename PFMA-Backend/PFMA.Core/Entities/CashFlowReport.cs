using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Cash Flow Reporting
    public class CashFlowReport
    {
        [Key]
        public int ReportId { get; set; }

        [Required]
        public DateTime DateGenerated { get; set; }

        [Required]
        public string Criteria { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
