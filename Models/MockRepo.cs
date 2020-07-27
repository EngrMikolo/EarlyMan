using System.Collections.Generic;
using System.Linq;

namespace Telefin.Models
{
    public class MockRepo : IPrintRepository
    {
        public IQueryable<Print> Prints => new List<Print>
        {
            new Print{Name = "Einstein", Price = 5000M, 
                Description = "Albert Einstein was a German-born theoretical physicist who developed " +
                "the theory of relativity, one of the two pillars of modern physics " +
                "(alongside quantum mechanics).: " +
                "His work is also known for its influence on the philosophy of science",
                Location = ""},
             new Print{Name = "Sealing Wand", Price = 5000M, 
                 Description = "The Sealing Wand also simply referred to as the Staff," +
                 " is a dark pink magical staff or wand about a meter in length.",
                Location = ""},
              new Print{Name = "Groot", Price = 3000M, 
                  Description = "I am Groot",
                Location = ""},
               new Print{Name = "Hulk", Price = 15000M, Description = "Smash",
                Location = ""},
            new Print{Name = "Castle", Price = 8000M, Description = "",
                Location = ""}
        }.AsQueryable();
    }
}