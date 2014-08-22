using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
namespace LotterySystem.Service
{
    public class EntranceServcieImpl : EntranceServcie
    {
        public bool enterRoomCheck(UserModel user, RoomModel room)
        {
            return true;
        }
    }
}