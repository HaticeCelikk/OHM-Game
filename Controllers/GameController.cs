using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models; //modeldakileri artık tanıyoruz

namespace shopapp.webui.Controllers
{
    public class GameController:Controller
    {
        public IActionResult Index(){
        //viewbag
        //model
        //vievdata
        var game=new Game{Name="lol",Price=2,Description="burkinin fave oyunu"};
        // ViewData["Game"]  = game;
        // ViewData["Category"]="3ps oyunları";
        ViewBag.Category="fpsssdğil";
        ViewBag.Game=game;
        return View(game);
        }
        public IActionResult list(){

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
        public IActionResult Details(int p){
            //viewdata kullanınca cast işlemi yapman gerek
            // ViewBag.Name="valorant";
            // ViewBag.Price=20;
            // ViewBag.Description="fps game";
            var g = new Game();
            g.Name="valo";
            g.Price=235;
            g.Description="2017 çıkışlı oyun";
            return View(g);  //  localhost:5000/game/details
        }

        

        
    }
}