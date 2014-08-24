using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
namespace LotterySystem.Service
{

    public class ConventServiceImpl:ConvertService
    {
        public RoomModel toRoomModel(Room room)
        {
            return new RoomModel();
        }

        public GameModel toGameModel(LotterySystem.Po.Game game)
        {
           GameModel gameModel=  new GameModel();
           gameModel.AllRoomLimit = game.PlayerSelectNumTimeLimit;
           gameModel.BankerSelectNumTimeLimit = game.BankerSelectNumTimeLimit;
           gameModel.Browser = game.Browser;
           gameModel.GameName = game.GameName;
           gameModel.GameStatus = game.GameStatus;
           gameModel.OnePersonRoomLimit = game.OnePersonRoomLimit;
           gameModel.OneRoomTableLimit = game.OneRoomTableLimit;
           gameModel.OneTablePersonLimit = game.OneTablePersonLimit;
           gameModel.Os = game.Os;
           gameModel.PlayerSelectNumTimeLimit = game.PlayerSelectNumTimeLimit;
           gameModel.TaxRate = game.TaxRate;

           return gameModel;
        }
    }
}