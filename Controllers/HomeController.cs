using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{  
    public class HomeController:Controller
    {   //Action part
        public IActionResult Index(){
            var games =new List<Game>()
            {
                new Game {Name="among us",Price=8, Description="yalan söyle"},
                new Game {Name="zula",Price=200, Description="berbat oyun"},
                new Game {Name="uga buga",Price=5, Description="tiktok"},
                new Game {Name="among us",Price=1, Description="yalan söyle"},
                new Game {Name="zula",Price=20, Description="berbat oyun"},
                new Game {Name="uga buga",Price=8, Description="tiktok"},
                new Game {Name="among us",Price=45, Description="yalan söyle"},
                new Game {Name="zula",Price=30, Description="berbat oyun"},
                new Game {Name="uga buga",Price=27, Description="tiktok"}
            };      
            
            var gameViewModel= new GameViewModel(){
                Game=games
            };



            return View(gameViewModel); 
        }
        public IActionResult About(){
            return View();  //  localhost:5000/home/about
        }
        
        
    }
}