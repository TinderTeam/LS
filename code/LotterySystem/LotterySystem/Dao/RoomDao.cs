﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Dao
{
    public interface RoomDao
    {
        Room getRoomByName(string roomName);
        List<Room> getRoomByGameNameAndStatus(string roomName,string status);

    }
}