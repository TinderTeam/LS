using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
namespace LotterySystem.Service
{
    public interface PlatService
    {
        RoomListModel getRoomListByGameID(string id);
    }
}
