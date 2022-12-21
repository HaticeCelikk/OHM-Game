using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.data.Abstract;
using shopapp.webui.Data;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{  
    public class HomeController:Controller
    {   //Action part

        private IGameRepository _gameRepository;
        public HomeController(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }
        public IActionResult Index(){

            
            var gameViewModel= new GameViewModel(){
               Game=GameRepository.Game
            };



            return View(gameViewModel); 
        }
        public IActionResult About(){
            return View();  //  localhost:5000/home/about
        }
        
        
    }
}