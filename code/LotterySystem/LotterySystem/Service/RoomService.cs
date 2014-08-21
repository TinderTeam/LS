using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LotterySystem.Models;
namespace LotterySystem.Service
{
    interface RoomService
    {
        /// <summary>
        /// 获取当前游戏房间
        /// </summary>
        /// <returns></returns>
        List<RoomModel> getRoomList();


        /// <summary>
        /// 创建并进入新的游戏房间
        /// </summary>
        /// <param name="room">创建的房间信息</param>
        /// <returns>被创建的房间</returns>
        RoomModel createNewRoomAndEnter(RoomModel room);

        /// <summary>
        /// 用户进入房间
        /// </summary>
        /// <param name="user">进入用户</param>
        /// <param name="room">进入的房间</param>
        /// <returns></returns>
        bool enterRoom(UserModel user,RoomModel room);

        /// <summary>
        /// 用户退出房间
        /// </summary>
        /// <param name="user"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        bool exitRoom(UserModel user);



    }
}
