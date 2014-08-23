using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
using LotterySystem.Po;
namespace LotterySystem.Service
{
    public interface PlatService
    {
        List<RoomModel>  getOpenRoomListByGameName(string gameID);
        List<GameModel>  getGameList();
        List<TableModel> getAllTableByGameAndRoom(string room, string game);

        RoomModel getRoomByName(string roomID);
        GameModel getGameByName(string gameName);

      
    }
    public interface ConvertService
    {
        RoomModel toRoomModel(Room room);
        GameModel toGameModel(LotterySystem.Po.Game game);
    }


    public interface EntranceServcie
    {
        bool enterRoomCheck(UserModel user, RoomModel room);
    }

    public interface LoginService
    { 
        bool Login(string userID ,string password);
        UserModel getLoginUser(string userID);
        bool LoginCheck();
    }
}
