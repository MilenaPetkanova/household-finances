namespace HouseholdFinances.Data
{
    using FamilyIncomeExpences.Data.Models.Capital;
    using Microsoft.EntityFrameworkCore;

    public class HouseholdFinancesContext : DbContext
    {
        public HouseholdFinancesContext(DbContextOptions<HouseholdFinancesContext> options)
            : base(options)
        { }

        public DbSet<Capital> Capitals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
