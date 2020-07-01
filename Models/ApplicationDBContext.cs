using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace Telefin.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
                : base(options) { }
        public DbSet<Print>Prints { get; set; }
    }
}
