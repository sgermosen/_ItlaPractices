using Microsoft.EntityFrameworkCore;
using PaqJet.Domain.Entities;

namespace PaqJet.Domain
{
    public class PaqJetDbContext : DbContext
    {
        public PaqJetDbContext(DbContextOptions<PaqJetDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Paq> Paqs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
