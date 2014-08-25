using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using LotterySystem.Models;
namespace LotterySystem.Dao
{
    public class RoomDaoImpl :RoomDao
    {
        public Room getRoomByName(String roomName)
        {
            return null;
        }


        public List<Room> getRoomListByGameAndHoster(string gameName, String hoster)
        {
            List<Room> roomList = DBStub.getDBStub().getRoomList();
            List<Room> list = new List<Room>();
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].GameName.Equals(gameName) && roomList[i].RoomHost.Equals(hoster))
                {
                    list.Add(roomList[i]);
                }
            }
            return list;
        }
       public  List<Room> getRoomByGame(string gameName)
        {
            List<Room> roomList = DBStub.getDBStub().getRoomList();
            List<Room> list = new List<Room>();
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].GameName.Equals(gameName))
                {
                    list.Add(roomList[i]);
                }
            }
            return list;
        }

        public List<Room> getRoomByGameNameAndStatus(string gameName,string status)
        {
            List<Room> roomList= DBStub.getDBStub().getRoomList();
            List<Room> list = new List<Room>();
            for (int i = 0; i < roomList.Count; i++)
            {
                if (roomList[i].GameName.Equals(gameName) && roomList[i].Status.Equals(RoomConstatns.STATUS_OPEN))
                {
                    list.Add(roomList[i]);
                }
            }
            return list;
        }

        public List<Room> getAll()
        {
            return null;
        }

        public void createRoom(Room room)
        {
            List<Room> roomList = DBStub.getDBStub().getRoomList();
            roomList.Add(room);
        }
        public void deleteRoomByRoomName(String roomName)
        {
        }
        public void updateRoom(Room room)
        {
        }
    }
}