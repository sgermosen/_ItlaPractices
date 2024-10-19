using Microsoft.EntityFrameworkCore;
using Prestify.Domain.Entities;


namespace Prestify.Domain
{
    public class PrestifyDbContext : DbContext
    {

        public PrestifyDbContext(DbContextOptions<PrestifyDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
