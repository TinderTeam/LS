using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface DoorDao
    {
        List<Door> getAll();
        void creatDoor(Door door);
        void deleteDoorByRoomID(String roomID);
        void updateDoor(Door door);
        void creatDoor(List<Door> list);
        List<Door> getDoorByGameAndRoomAndType(string game, string room, string type);
    }
}