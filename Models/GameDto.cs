using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShelf.Models
{
    public class GameDto
    {
        public string Name { get; set; } = "No name";
        public string Description { get; set; } = "No description";
        public string Genre { get; set; } = "Unknown";
        public double Rating { get; set; } = 1.0;
        public decimal Price { get; set; } = 1.0m;
    }
}
