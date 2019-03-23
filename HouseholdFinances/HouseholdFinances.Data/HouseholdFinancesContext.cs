namespace HouseholdFinances.Data
{
    using Microsoft.EntityFrameworkCore;
    using HouseholdFinances.Data.Models.Capital;
    using HouseholdFinances.Data.Models.Expense;

    public class HouseholdFinancesContext : DbContext
    {
        public HouseholdFinancesContext(DbContextOptions<HouseholdFinancesContext> options)
            : base(options)
        { }

        public DbSet<Capital> Capitals { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
