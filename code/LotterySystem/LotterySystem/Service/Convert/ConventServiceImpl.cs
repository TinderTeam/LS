using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
namespace LotterySystem.Service
{

    public class ConventServiceImpl:ConvertService
    {
        public RoomModel toRoomModel(Room room)
        {
            return new RoomModel();
        }
    }
}