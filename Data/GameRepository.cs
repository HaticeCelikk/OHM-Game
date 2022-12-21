using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.webui.Models;
using MySql.Data.MySqlClient;

namespace shopapp.webui.Data
{
    public static class GameRepository
    {
        private static List<Game> _games= new List<Game>();

        

        static GameRepository()
        {
             
            _games=new List<Game>{
                new Game {GameId=1,Name="among us",Price=8, Description="yalan söyle",ImageUrl="1.jpg",CategoryId = 1},
                new Game {GameId=2,Name="zula",Price=200, Description="berbat oyun",ImageUrl="2.jpg",CategoryId = 2},
                new Game {GameId=3,Name="uga buga",Price=5, Description="tiktok",ImageUrl="3.jpg",CategoryId = 3},
                new Game {GameId=4,Name="among us",Price=1, Description="yalan söyle",ImageUrl="mayis.jpg",CategoryId = 1},
                new Game {GameId=5,Name="zula",Price=20, Description="berbat oyun",ImageUrl="mayis.jpg",CategoryId = 1},
                new Game {GameId=6,Name="sims4",Price=5, Description="tiktok",ImageUrl="3.jpg",CategoryId = 2},
                new Game {GameId=7,Name="elden ring",Price=1, Description="yalan söyle",ImageUrl="mayis.jpg",CategoryId = 3},
                new Game {GameId=8,Name="brawlhalla",Price=20, Description="berbat oyun",ImageUrl="mayis.jpg",CategoryId = 3}



            };
        
        }
        // örnek metot
       
        public static List<Game> Game{
            get{
                return _games;
            }
        }

        public static void AddGame(Game g){
            _games.Add(g);
        }
        public static Game GetGameById(int id){
            return _games.FirstOrDefault(g => g.GameId==id);
        }
    }
    
}


