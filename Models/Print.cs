using System;
using System.Collections.Generic;

namespace Telefin.Models
{
    public class Print
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }

        //AvailableColors { get; set; }
        //MaterialType{ get; set; }
        //Sizes { get; set;}
        public string Categories { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }
    }
}