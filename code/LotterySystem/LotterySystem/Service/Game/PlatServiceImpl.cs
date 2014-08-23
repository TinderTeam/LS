using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
using LotterySystem.Service;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Po;

namespace LotterySystem.Service
{

    public class PlatServiceImpl : PlatService
    {
        RoomDao roomDao = DaoContext.getInstance().getRoomDao();
        GameDao gameDao = DaoContext.getInstance().getGameDao();
        ConvertService converService = ServiceContext.getInstance().getConvertService();
        EntranceServcie entranceService = ServiceContext.getInstance().getEntranceServcie();
        ///GamblingPartyDao gamblingPartyDao = DaoContext.getInstance().getGamblingPartyDao();

        /// <summary>
        /// 获得游戏列表
        /// </summary>
        /// <returns></returns>
        public List<GameModel> getGameList()
        {
            List<GameModel> gameModelList = new List<GameModel>();
            List<LotterySystem.Po.Game> gameList = gameDao.getAll();
            for (int i = 0; i < gameList.Count; i++)
            {
                GameModel gameModel = converService.toGameModel(gameList[i]);
                gameModelList.Add(gameModel);            
            }
            return gameModelList;
        }

        /// <summary>
        /// 获取游戏信息
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns></returns>
        public GameModel getGameByName(string gameName)
        {
            GameModel gameModel = converService.toGameModel( gameDao.getGameByName(gameName));
            return gameModel;
        }

        /// <summary>
        /// 根据游戏名字查询符合开放条件的列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<RoomModel> getOpenRoomListByGameName(string gameName)
        {
            List<RoomModel> roomModelList = new List<RoomModel>();
            List<Room> roomList = roomDao.getRoomByGameNameAndStatus(gameName,RoomConstatns.STATUS_OPEN);
            for (int i = 0; i < roomList.Count; i++)
            {
                RoomModel roomModel = converService.toRoomModel(roomList[i]);
                roomModelList.Add(roomModel);
            }
            return roomModelList;
        }


        /// <summary>
        /// 根据房间名和游戏名获得桌子列表
        /// </summary>
        /// <param name="room"></param>
        /// <param name="game"></param>
        /// <returns></returns>
        public List<TableModel> getAllTableByGameAndRoom(string room, string game)
        {
            List<TableModel> tableList = new List<TableModel>();
            
            ///尚未实现
            ///List<GamblingParty> gamblingParty = gamblingPartyDao.getGamblingPartyByGameAndRoom(game, room);
            ///
            return tableList;
        }



        /// <summary>
        /// 通过名称获取房间
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public RoomModel getRoomByName(string roomName)
        {
            RoomModel room = converService.toRoomModel(roomDao.getRoomByName(roomName));
            return room;
        }
        
    }
}