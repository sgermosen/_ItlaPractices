using ExpressTaste.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpressTaste.Web.Data
{
    public class ExpressTasteDbContext : DbContext
    {
        public ExpressTasteDbContext(DbContextOptions<ExpressTasteDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Order> Orders { get; set; }  
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
