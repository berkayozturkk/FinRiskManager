using FinanceRiskManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceRiskManagement.Data.Contexts
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<BusinessTopic> BusinessTopics { get; set; }
        public DbSet<RiskAnalysis> RiskAnalyses { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<AgreementBusinessTopic> AgreementBusinessTopics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customize the model if necessary
            // modelBuilder.Entity<User>().HasKey(u => u.Id); // for example
        }
    }
}
