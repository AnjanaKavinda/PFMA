using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // Future Finance Forecast
    public class FinanceForecast
    {
        [Key]
        public int ForecastId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
