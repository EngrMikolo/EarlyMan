using Microsoft.EntityFrameworkCore;

namespace Telefin.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

        public DbSet<Print> RegularPrints { get; set; }
        public DbSet<Print> Carousel { get; set; }
    }
}