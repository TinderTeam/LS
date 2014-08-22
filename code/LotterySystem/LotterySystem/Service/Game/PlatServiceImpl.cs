using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
using LotterySystem.Service;
using LotterySystem.Models;

namespace LotterySystem.Service
{
    public class PlatServiceImpl : PlatService
    {
        /// <summary>
        /// 根据游戏ID 查询房间
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RoomListModel getRoomListByGameID(string id)
        {

            //Test Stub
            return RoomSrub.getRoomListModel();
        }
    }
}