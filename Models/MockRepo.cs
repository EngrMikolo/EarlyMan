using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Telefin.Models
{
    public class MockRepo : IPrintRepository
    {
        public IQueryable<Print> Prints => new List<Print>
        {
            new Print{Name = "Monkey", Price = 200000M, Location = ReturnFilePath("Monkey")},
            new Print{Name = "Lion", Price = 40000M, Location = ReturnFilePath("Lion")},
            new Print{Name = "Snake", Price = 20000M, Location = ReturnFilePath("Snake")},
            new Print{Name = "Tiger", Price = 20000M, Location = ReturnFilePath("Tiger")},
            new Print{Name = "Horse", Price = 20000M, Location = ReturnFilePath("Horse")}

        }.AsQueryable();

        private static  string ReturnFilePath(string fileName)
        {
            // Method should return the location of the image.
            // Take string from Prints
            return Path.Combine("\\wwwroot\\TempImages", $"{fileName}");
        }
    }
}