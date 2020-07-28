
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Telefin.Models
{
    public class SeedData
    {

        public SeedData(IConfiguration config) => Configuration = config;

        public IConfiguration Configuration { get; }

        public static void EnsurePopulated(IApplicationBuilder app)
        {

            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();


            context.Database.Migrate();

            if (!context.Prints.Any())
            {
                context.Prints.AddRange(
                    new Print
                    {
                        Name = "SealingWand",
                        Price = 50000,
                        Description = "A magic wand of power 10",
                        Categories = "Toy",
                        Id = GenerateGUID(),
                        Location = "SealingWand"
                    },
                    new Print
                    {
                        Name = "Castle",
                        Price = 20000,
                        Description = "Replacement chess piece",
                        Categories = "Game",
                        Id = GenerateGUID(),
                        Location = "Castle"
                    },
                    new Print
                    {
                        Name = "Einstein",
                        Price = 40000,
                        Description = "Science Genius with nice hair",
                        Categories = "Toy",
                        Id = GenerateGUID(),
                        Location = "Einstein"
                    },
                    new Print
                    {
                        Name = "Groot",
                        Price = 15000,
                        Description = "Cutie from marvel cinematic universe",
                        Categories = "Toy",
                        Id = GenerateGUID(),
                        Location = "Groot"
                    },
                    new Print
                    {
                        Name = "Hulk",
                        Price = 50000,
                        Description = "Green, always angry, strong",
                        Categories = "Toy",
                        Id = GenerateGUID(),
                        Location = "Hulk"
                    },
                    new Print
                    {
                        Name = "Valkyrie",
                        Price = 80000,
                        Description = "Fighter Jet",
                        Categories = "Toy",
                        Id = GenerateGUID(),
                        Location = "Valkyrie"
                    }

                    );
                context.SaveChanges();

            }

        }
        static string GenerateGUID()
        {
            return System.Guid.NewGuid().ToString();


        }
    }
}
