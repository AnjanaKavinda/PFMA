using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Core.Entities
{
    // User Authentication
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Country { get; set; }
        public string JObTitle { get; set; }
        public string Company { get; set; } 

        //[Required]
        //public string Role { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<SavingsAccount> SavingsAccounts { get; set; }
        public ICollection<Budget> Budgets { get; set; }
        public ICollection<BillDocument>  BillDocuments { get; set; }
        public ICollection<FinanceForecast> FinanceForecasts { get; set; }
        public ICollection<InterestCalculation>  InterestCalculations { get; set; }
        public ICollection<BudgetAlert>  BudgetAlerts { get; set; }
        public ICollection<CashFlowReport>  CashFlowReports { get; set; }
        public ICollection<Forecast>  Forecasts { get; set; }
    }
}
