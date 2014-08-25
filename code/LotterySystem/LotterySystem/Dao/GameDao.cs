using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Dao
{
    public interface GameDao
    {
        List<Game> getAll();
        Game getGameByName(String gameName);
        void creatGame(Game game);
        void deleteGameByName(String gameName);
        void updateGame(Game game);

      
    }
}