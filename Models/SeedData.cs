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

            if (!context.Carousel.Any())
            {
                context.Carousel.AddRange(
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
            }
            if (!context.RegularPrints.Any())
            {
                context.RegularPrints.AddRange(
                    new Print
                    {
                        Name = "Covid19_Joke",
                        Price = 2500,
                        Description = "Corona virus joke poster",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img1"
                    }, new Print
                    {
                        Name = "NigerianOrtodox",
                        Price = 20000,
                        Description = "Ancient orthodox catholic" +
                        "woman from Nigeria.",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img2"
                    },
                   new Print
                   {
                       Name = "SpongeBob_Unmiss",
                       Price = 500,
                       Description = "\"He never misses\" joke",
                       Categories = "FramedPhoto",
                       Id = GenerateGUID(),
                       Location = "img3"
                   },
                    new Print
                    {
                        Name = "CrazyComp",
                        Price = 5000,
                        Description = "3D render of a crazy computer",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img4"
                    },
                    new Print
                    {
                        Name = "PonziSchemeSpotter",
                        Price = 2500,
                        Description = "Educative image of how to " +
                        "spot a Ponzi scheme",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img5"
                    },
                    new Print
                    {
                        Name = "Scooby doo vs Interfaces",
                        Price = 6000,
                        Description = "Interface joke",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img6"
                    },
                    new Print
                    {
                        Name = "IQ Joke",
                        Price = 20000,
                        Description = "One Piece IQ joke",
                        Categories = "FramedPhoto",
                        Id = GenerateGUID(),
                        Location = "img7"
                    }
                    );
            }
            context.SaveChanges();
        }

        private static string GenerateGUID()
        {
            return System.Guid.NewGuid().ToString();
        }
    }
}