using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
using LotterySystem.Service;
using LotterySystem.Models;
using LotterySystem.Dao;


namespace LotterySystem.Service
{

    public class PlatServiceImpl : PlatService
    {
        RoomDao roomDao = DaoContext.getInstance().getRoomDao();
        ConvertService converService = ServiceContext.getInstance().getConvertService();
        EntranceServcie entranceService = ServiceContext.getInstance().getEntranceServcie();

        public List<GameInfoModel> getGameList()
        {
            return SysStub.getGameList();
        }

        /// <summary>
        /// 根据游戏ID 查询房间
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RoomListModel getRoomListByGameID(string id)
        {

            //Test Stub
            return RoomStub.getRoomListModel();
        }

        /// <summary>
        /// 用户进入房间
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public RoomModel enterRoom(UserModel user, string roomID)
        {
            RoomModel room = converService.toRoomModel(roomDao.getRoomByID(roomID));
            
            if(entranceService.enterRoomCheck(user,room))
            {
                //用户加入
                //user.UserInfor.setPositionByRoomInfo(room.RoomID, room.RoomName);



                //Stub
                room = RoomStub.getRoomModel(10);
                return room;
            }else{
                //无进入权限
                return null;
            }
            
        }
    }
}