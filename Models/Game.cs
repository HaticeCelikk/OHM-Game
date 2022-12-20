using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string? Name { get; set; } 
        public double Price { get; set; } 
     
        public string? Description { get; set; } 
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
    }
}