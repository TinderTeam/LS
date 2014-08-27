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

        RoomModel getRoomByGameAndName(string gameName,string roomName);
        GameModel getGameByName(string gameName);

        String createRoom(String gameName, UserModel user,RoomForm model);
        String editRoomInfo(RoomForm model);
    }

    public interface ConvertService
    {
        RoomModel toRoomModel(Room room);
        RoomModel toRoomModel(RoomForm form);
        Room toRoom(RoomForm form);
        GameModel toGameModel(LotterySystem.Po.Game game);

        List<Door> toDoor(RoomForm model);

    }

    public interface EntranceServcie
    {
        bool enterRoomCheck(UserModel user, RoomModel room);
    }

    public interface LoginService
    { 
        bool Login(string userName ,string password);
        UserModel getLoginUser(string userName);
        bool LoginCheck();
    }
    public interface UserService
    {
        bool CreateRoomCheck(UserModel user);
        List<UserModel> getUserList(String userName);
    }
}
