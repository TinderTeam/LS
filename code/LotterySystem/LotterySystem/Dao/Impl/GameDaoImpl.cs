using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Dao
{
    public class GameDaoImpl:GameDao
    {
        public List<Game> getAll(){

            return new List<Game>();
        }
        public Game getGameByName(String gameName)
        {
            return new Game();
        }
    }
}