using Microsoft.EntityFrameworkCore;
using PFMA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMA.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BillDocument> BillDocuments { get; set; }
        public DbSet<FinanceForecast> FinanceForecasts { get; set; }
        public DbSet<InterestCalculation> InterestCalculations { get; set; }
        public DbSet<BudgetAlert> BudgetAlerts { get; set; }
        public DbSet<CashFlowReport> CashFlowReports { get; set; }
        public DbSet<Forecast> Forecasts { get; set; }
    }
}
