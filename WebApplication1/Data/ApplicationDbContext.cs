using Microsoft.EntityFrameworkCore;
using Task11.Models;

namespace Task11.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<FinancialOperation> FinancialOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinancialOperation>()
                .HasOne(x => x.Incomes)
                .WithMany(x => x.FinancialOperations)
                .HasForeignKey(x => x.IncomeId);

            modelBuilder.Entity<FinancialOperation>()
                .HasOne(x => x.Expenses)
                .WithMany(x => x.FinancialOperations)
                .HasForeignKey(x => x.ExpenseId);
        }

    }
}
