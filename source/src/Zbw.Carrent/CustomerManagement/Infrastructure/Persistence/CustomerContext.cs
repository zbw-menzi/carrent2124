namespace Zbw.Carrent.CustomerManagement.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;

    using Zbw.Carrent.CustomerManagement.Domain;

    public class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; }
    }
}
