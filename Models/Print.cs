using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefin.Models
{
    public class Print
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }
        public List<string> AvailableColors { get; set; }
        public List<string> MaterialType{ get; set; }
        public int Size { get; set; }
        public string Categories { get; set; }
        public string Location { get; set; }
    }
}
