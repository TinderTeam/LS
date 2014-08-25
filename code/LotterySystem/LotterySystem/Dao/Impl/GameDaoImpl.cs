using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao
{
    public class GameDaoImpl:GameDao
    {
        public List<Game> getAll(){

            return DBStub.getDBStub().getGameList();
        }
        public Game getGameByName(String gameName)
        {
            return new Game();
        }
        public void creatGame(Game game)
        {
        }
        public void deleteGameByName(String gameName)
        {
        }
        public void updateGame(Game game)
        {
        }
    }
}