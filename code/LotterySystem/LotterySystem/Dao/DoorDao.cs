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
        Door getDoorByRoomID(String roomID);
        void creatDoor(Door door);
        void deleteDoorByRoomID(String roomID);
        void updateDoor(Door door);

    }
}