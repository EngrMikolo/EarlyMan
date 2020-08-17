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

            if (!context.Promos.Any())
            {
                context.Promos.AddRange(
                    new Promotion
                    {
                        Name = "SealingWand",
                        Description = "A magic wand of power 10",
                        Id = GenerateGUID(),
                        Location = "SealingWand"
                    },
                    new Promotion
                    {
                        Name = "Castle",

                        Description = "Replacement chess piece",
                        Id = GenerateGUID(),
                        Location = "Castle"
                    },
                    new Promotion
                    {
                        Name = "Einstein",
                        Id = GenerateGUID(),
                        Description = "Science Genius with nice hair",

                        Location = "Einstein"
                    },
                    new Promotion
                    {
                        Name = "Groot",
                        Id = GenerateGUID(),
                        Description = "Cutie from marvel cinematic universe",

                        Location = "Groot"
                    },
                    new Promotion
                    {
                        Name = "Hulk",
                        Id = GenerateGUID(),
                        Description = "Green, always angry, strong",

                        Location = "Hulk"
                    },
                    new Promotion
                    {
                        Name = "Valkyrie",
                        Id = GenerateGUID(),
                        Description = "Fighter Jet",

                        Location = "Valkyrie"
                    }

                    );
            }
            if (!context.Prints.Any())
            {
                context.Prints.AddRange(
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