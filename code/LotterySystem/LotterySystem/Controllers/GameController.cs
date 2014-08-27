using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
using LotterySystem.Service.Login;
using LotterySystem.Service;
namespace LotterySystem.Controllers
{
    public class GameController : Controller
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        PlatService platService = ServiceContext.getInstance().getPlatService();
        UserService userService = ServiceContext.getInstance().getUserService();

        /// <summary>
        /// 进入游戏大厅
        /// </summary>
        /// <param name="gameID"></param>
        /// <returns></returns>
        public ActionResult Hall()
        {
            log.Debug("Page: [Hall]");
            //验证用户
            ViewBag.GameList = platService.getGameList();
            ViewBag.GameListCount = platService.getGameList().Count;
            log.Debug("Page: [Hall] --- GameNumber = " + ViewBag.GameListCount);
            return View();   
                
        }

        /// <summary>
        /// 新建房间
        /// 1.检查用户是否有房间创建权限
        /// 2.检查当前游戏房间总数是否到上限
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult NewRoom(RoomForm model)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            GameModel game = (GameModel)Session["CurrentGame"];
            //创建房间
            String result = platService.createRoom(game.GameName, user, model);
            if (result.Equals(SysConstants.SUCCESS))
            {
                return RedirectToAction("RoomPage", "Game");
                // return RedirectToAction("TablePage", "Game");
            }
            else
            {
                @ViewBag.Msg = result;
                @ViewBag.Model = model;
                return View();
            }
        }



        [HttpPost]
        public ActionResult RoomEdit(RoomForm model) 
        {
            log.Debug("[RoomEdit] Submit model="+model);
            UserModel user = (UserModel)Session["SystemUser"];
            GameModel game = (GameModel)Session["CurrentGame"];
            @ViewBag.User = user;
            @ViewBag.Game = game;

            if (ModelState.IsValid)
            {
                //修改房间内容
                string result = platService.editRoomInfo(model);
                if (result.Equals(SysConstants.SUCCESS))
                {
                    @ViewBag.Msg = RoomConstatns.CREATE_ROOM_SUCCESS;
                    return RedirectToAction("RoomPage", "Game");
                }else{
                    @ViewBag.Msg = result;
                    return View();
                } 
            }
            return RedirectToAction("RoomPage", "Game");
        }

        /// <summary>
        /// 房间管理
        /// </summary>
        /// <returns></returns>
        public ActionResult RoomEdit(string roomName)
        {
            log.Debug("Enter [RoomEdit]Page， roomName= "+roomName);
            GameModel game = (GameModel)Session["CurrentGame"];          
            RoomModel room =platService.getRoomByGameAndName(game.GameName, roomName);
       
            @ViewBag.Room = room;
            @ViewBag.Game = game;
            return View();
        }

        /// <summary>
        /// 显示新建房间的界面
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult NewRoom()
        {
            UserModel user = (UserModel)Session["SystemUser"];
            GameModel game= (GameModel)Session["CurrentGame"];
            //检查用户房间管理权限
            if (userService.CreateRoomCheck(user))
            {
                @ViewBag.User = user;
                @ViewBag.Game = game;
                return View();
            }
            else
            {   
                @ViewBag.Msg = "无用户创建权限";
                return  RedirectToAction("Hall", "Game");
            }
           
        }

        /// <summary>
        /// 房间列表界面
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns></returns>
        public ActionResult RoomPage(String gameNameArg)

        {
            string gameName;
            //将Game放入Session
            if (gameNameArg != null)
            {
                Session["CurrentGame"] = platService.getGameByName(gameNameArg);
                gameName = gameNameArg;
            }
            else
            {
                GameModel game = (GameModel)Session["CurrentGame"];
                gameName = game.GameName;
            }

 
            //获取当前登录用户
            UserModel user = (UserModel)Session["SystemUser"];

            //显示房间
            List<RoomModel> roomList = platService.getOpenRoomListByGameName(gameName);
            ViewBag.roomListCount = roomList.Count;
            ViewBag.roomList = roomList;
            return View();
        }


        public ActionResult RoomList(String gameName)
        {
            return View();
        }


        /// <summary>
        /// 桌子列表界面
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public ActionResult TablePage(String roomName)
        {

            //获取Session信息
            UserModel user = (UserModel)Session["SystemUser"];
            GameModel game = (GameModel)Session["CurrentGame"];
            RoomModel room;
            string roomNameArg;
            //将Game放入Session
            if (roomName != null)
            {

                room = platService.getRoomByGameAndName(game.GameName,roomName);
                Session["CurrentRoom"] = room;
                roomNameArg = roomName;
            }
            else
            {
                room = (RoomModel)Session["CurrentGame"];
                roomNameArg = room.RoomName;
            }
            //将Room放入Session

            //显示桌子
            List<TableModel> tableModelList = platService.getAllTableByGameAndRoom(game.GameName, roomNameArg);
            ViewBag.tableListCount = tableModelList.Count;
            ViewBag.tableList = tableModelList;
            return View();
        }


        /// <summary>
        /// 显示桌子列表
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public ActionResult TableList()
        {           
            return View();
        }



        public ActionResult Game()
        {
            return View();
        }
        public ActionResult AddGame()
        {
            return RedirectToAction("Game", "Game");
        }

        public ActionResult NewGame()
        {
            return RedirectToAction("Game", "Game");
        }




        public ActionResult GameEdit()
        {
            return View();
        }
    }
}
