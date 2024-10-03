using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaqJet.Web.Models.Entities;

namespace PaqJet.Web.Data
{
    public class PaqJetDbContext : DbContext
    {
        public PaqJetDbContext (DbContextOptions<PaqJetDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Paq> Paqs { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Status> Status { get; set; }
    }
}
