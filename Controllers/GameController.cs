using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
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
        public IActionResult list(int? id,string q){
            var games = GameRepository.Game;

            if(id!=null){
                games = games.Where(p => p.CategoryId == id).ToList();
            }
            if(!string.IsNullOrEmpty(q)){
                games = games.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
            }
         
            var gameViewModel= new GameViewModel(){
                Game= games
            };
            



            return View(gameViewModel); 
        }
        public IActionResult Details(int id){
            return View(GameRepository.GetGameById(id));  //  localhost:5000/game/details
        }

        public IActionResult Create()
        {
            return View();
        }
        

        
    }
}