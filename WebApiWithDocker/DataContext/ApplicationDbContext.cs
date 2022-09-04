using WebApiWithDocker.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApiWithDocker.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
    }
}
