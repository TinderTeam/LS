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
        RoomListModel getRoomListByGameID(string id);
        RoomModel enterRoom(UserModel user,string roomID);
    }
    public interface ConvertService
    {
        RoomModel toRoomModel(Room room);
    }


    public interface EntranceServcie
    {
        bool enterRoomCheck(UserModel user, RoomModel room);
    }
}
