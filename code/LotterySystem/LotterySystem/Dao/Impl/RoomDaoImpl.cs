using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public class RoomDaoImpl :RoomDao
    {
        public Room getRoomByName(String roomName)
        {
            return new Room();
        }
        public List<Room> getRoomByGameNameAndStatus(string roomName,string status){
            return null;
        }
    }
}