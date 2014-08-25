using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface RoomDao
    {
        List<Room> getAll();
        List<Room> getRoomByGameNameAndStatus(string gameName, string status);
        List<Room> getRoomByGame(string gameName);
        List<Room> getRoomListByGameAndHoster(string gameName, String hoster);

        Room getRoomByName(string roomName);
        void createRoom(Room room);
        void deleteRoomByRoomName(String roomName);
        void updateRoom(Room room);
       

    }
}