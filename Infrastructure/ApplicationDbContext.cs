using Microsoft.EntityFrameworkCore;
using BudgetWizard.Domain.Entities;

namespace BudgetWizard.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Budget> Budgets { get; set; }
        // Add more DbSets as needed (e.g., Users, Transactions, etc.)
    }
}
