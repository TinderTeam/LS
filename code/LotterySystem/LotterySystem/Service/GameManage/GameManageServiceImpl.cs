using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Dao;
using LotterySystem.Po;
using LotterySystem.Models;

namespace LotterySystem.Service.GameManage
{
    public class GameManageServiceImpl:GameManageService
    {
        private GameDao gameDao = DaoContext.getInstance().getGameDao();
        public void modifyGame(GameModel gameModel)
        {
            Game game = new Game();
            game.GameName = gameModel.GameName;
            game.GameStatus = gameModel.GameStatus;
            game.Browser = gameModel.getBrowserStr();
            game.Os = gameModel.getOsStr();
            game.OnePersonRoomLimit = gameModel.OnePersonRoomLimit;
            game.OneRoomTableLimit = gameModel.OneRoomTableLimit;
            game.OneTablePersonLimit = gameModel.OneTablePersonLimit;
            game.PlayerSelectNumTimeLimit = gameModel.PlayerSelectNumTimeLimit;
            game.TaxRate = gameModel.TaxRate;
            game.BankerSelectNumTimeLimit = gameModel.BankerSelectNumTimeLimit;
            game.AllRoomLimit = gameModel.AllRoomLimit;
            gameDao.updateGame(game);
        }
    }
}