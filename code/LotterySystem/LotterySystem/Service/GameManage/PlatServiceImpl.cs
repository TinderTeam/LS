using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
using LotterySystem.Service;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Dao.Impl;
using LotterySystem.Po;

namespace LotterySystem.Service.GameManage
{

    public class PlatServiceImpl : PlatService
    {

        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        RoomDao roomDao = DaoContext.getInstance().getRoomDao();
        GameDao gameDao = DaoContext.getInstance().getGameDao();
        DoorDao doorDao = DaoContext.getInstance().getDoorDao();
        GamblingPartyDao gamblingPartyDao = DaoContext.getInstance().getGamblingPartyDao();


        public void deleteRoom(string gameName,string roomName)
        {
            roomDao.deleteRoomByRoomName(gameName,roomName);
        }

        /// <summary>
        /// 获得游戏列表
        /// </summary>
        /// <returns></returns>
        public List<GameModel> getGameList()
        {
            log.Debug("Serivce: [PlatService] --- getAllGame");
            List<GameModel> gameModelList = new List<GameModel>();
            List<LotterySystem.Po.Game> gameList = gameDao.getAll();
            for (int i = 0; i < gameList.Count; i++)
            {
                GameModel gameModel = ConventService.toGameModel(gameList[i]);
                if (gameModel != null)
                {
                    gameModelList.Add(gameModel);  
                }         
            }
            log.Debug("Serivce: [PlatService] --- getGameList: " +gameModelList.ToString());
            return gameModelList;
        }

        /// <summary>
        /// 获取游戏信息
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns></returns>
        public GameModel getGameByName(string gameName)
        {
            GameModel gameModel = ConventService.toGameModel(gameDao.getGameByName(gameName));         
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
                RoomModel roomModel = ConventService.toRoomModel(roomList[i]);
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
        public List<TableModel> getAllTableByGameAndRoom(string game, string room)
        {
            List<TableModel> tableList = new List<TableModel>();
            List<GamblingParty> gamblingParty = gamblingPartyDao.getGamblingPartyByGameAndRoom(game, room);
            
            //新建所有桌子

            for (int i = 0; i <getGameByName(game).OneRoomTableLimit ; i++)
            {
                TableModel tableModel = new TableModel();
                tableModel.GamblingPartyID = RoomConstatns.NULL;
                tableModel.TabelNo = i+1;
                tableModel.GameName = game;
                tableModel.Banker = RoomConstatns.NULL;
                tableModel.PlayerNum = 0;
                tableModel.RoomName = room;
                tableList.Add(tableModel);
            }

            //更新已有桌子
            for (int i = 0; i < gamblingParty.Count;i++ )
            {
                GamblingParty gp= gamblingParty[i];

                TableModel tableModel = tableList[gp.TableNum];
                tableModel.GamblingPartyID = gp.GamblingPartyID.ToString();
                tableModel.Banker = gp.Banker;
                tableModel.BankerEndTime = gp.BankerEndTime;
                tableModel.BankerStartTime = gp.BankerStartTime;
                //TODO
                tableModel.PlayerNum = 10;

            }
            return tableList;
        }

        

        /// <summary>
        /// 通过名称获取房间
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public RoomModel getRoomByGameAndName(string gameName,string roomName)
        {
            RoomModel room = ConventService.toRoomModel(roomDao.getRoomByGameAndRoom(gameName, roomName));
            return room;
        }
        
        /// <summary>
        /// 通过游戏和用户创建房间
        /// </summary>
        /// <param name="?"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public string  createRoom(string  gameName,UserModel user,RoomForm form){
            //校验游戏状态是否可以创建房间
            GameModel game= getGameByName(gameName);
            if (roomDao.getRoomByGame(gameName).Count + 1 > game.AllRoomLimit)
            {
                return RoomConstatns.ERR_ALLROOM_LIMIT;
            }
            if (roomDao.getRoomListByGameAndHoster(gameName, user.UserName).Count + 1 > game.OnePersonRoomLimit)
            {
                return RoomConstatns.ERR_USERROOM_LIMIT;
            }

            //准备Po
            Room room = ConventService.toRoom(form); //RoomPo
            room.RoomHost = user.UserName;
            room.GameName = gameName;
            room.Status = RoomConstatns.STATUS_OPEN;
            form.GameName = gameName;
            List<Door> doorList = ConventService.toDoor(form);
            doorDao.creatDoor(doorList);


            //校验
            /*
             * TODO
             */
            string result=checkRoomInfo(room);
            if (result.Equals(SysConstants.SUCCESS))
            {
                roomDao.createRoom(room);
            }
            return result;
        }

        public DoorListModel getDoorByGameAndRoom(string game, string room)
        {
            DoorListModel doolList = new DoorListModel();
            doolList.WhiteList = new List<DoorModel>();
            doolList.BlackList = new List<DoorModel>();

            List<Door> wlist = doorDao.getDoorByGameAndRoomAndType( game,room,UserConstants.ON);
            List<Door> blist = doorDao.getDoorByGameAndRoomAndType(game, room, UserConstants.OFF);

            foreach (Door door in wlist){
                DoorModel doorModel = new DoorModel();
                doorModel.GameName = door.GameName;
                doorModel.RoomName = door.RoomName;
                doorModel.UserName = door.UserName;
                doorModel.EntranceType = door.EntranceType;
                doolList.WhiteList.Add(doorModel);
            }

            foreach (Door door in blist)
            {
                DoorModel doorModel = new DoorModel();
                doorModel.GameName = door.GameName;
                doorModel.RoomName = door.RoomName;
                doorModel.UserName = door.UserName;
                doorModel.EntranceType = door.EntranceType;
                doolList.BlackList.Add(doorModel);
            }

            return doolList;
        }

        /// <summary>
        /// 
        /// 修改房间信息
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public string editRoomInfo(RoomForm form)
        {
            Room room = roomDao.getRoomByGameAndRoom(form.GameName, form.RoomName);
            room.RoomPassword = form.RoomPassword;
            room.Status = form.Status;
            room.AccessAcountLimit = form.AccessAcountLimit;
            room.Amplification = form.Amplification;
            room.BankerLimit = form.BankerLimit;
            room.BasicPoint = form.BasicPoint;

            string result = checkRoomInfo(room);
            if (result.Equals(SysConstants.SUCCESS))
            {
                roomDao.updateRoom(room);
            }
            return result;
        }

        /// <summary>
        /// 校验RoomInfo是否合法
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        private string checkRoomInfo(Room room)
        {
            return SysConstants.SUCCESS;
        }
    }
}