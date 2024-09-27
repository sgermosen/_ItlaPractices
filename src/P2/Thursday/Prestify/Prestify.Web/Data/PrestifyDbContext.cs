using Microsoft.EntityFrameworkCore;
using Prestify.Web.Models;

namespace Prestify.Web.Data
{
    public class PrestifyDbContext : DbContext
    {

        public PrestifyDbContext(DbContextOptions<PrestifyDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
