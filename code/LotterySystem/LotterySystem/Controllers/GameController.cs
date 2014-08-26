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
        PlatService platService = ServiceContext.getInstance().getPlatService();
        UserService userService = ServiceContext.getInstance().getUserService();

        /// <summary>
        /// 进入游戏大厅
        /// </summary>
        /// <param name="gameID"></param>
        /// <returns></returns>
        public ActionResult Hall()
        {     
                //验证用户
                ViewBag.GameList = platService.getGameList();
                ViewBag.GameListCount = platService.getGameList().Count;
                return View();                   
        }




        /// <summary>
        /// 新建房间
        /// 1.检查用户是否有房间创建权限
        /// 2.检查当前游戏房间总数是否到上限
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateRoom(RoomForm model, string returnUrl) 
        {
            UserModel user = (UserModel)Session["SystemUser"];
            GameModel game = (GameModel)Session["CurrentGame"];
            if (ModelState.IsValid)
            {            
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
                }
            }
            return RedirectToAction("NewRoom", "Game");
        }

        /// <summary>
        /// 显示新建房间的界面
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult NewRoom()
        {
            UserModel user = (UserModel)Session["SystemUser"];
            //检查用户房间管理权限
            if (userService.CreateRoomCheck(user))
            {
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
            //将Game放入Session
            Session["CurrentGame"] = platService.getGameByName(gameName);
            //获取当前登录用户
            UserModel user = (UserModel)Session["SystemUser"];

            //显示房间
            List<RoomModel> roomList = platService.getOpenRoomListByGameName(gameName);
            ViewBag.roomSize = roomList.Count;
            ViewBag.roomList = roomList;
            return View();
        }

        public ActionResult TablePage()
        {
            return View();
        }



        public ActionResult TableList(String roomName)
        {
            //将Room放入Session
            Session["CurrentRoom"] = platService.getRoomByName(roomName);
            //获取Session信息
            UserModel user = (UserModel)Session["SystemUser"];
            String gameName = (String)Session["CurrentGame"];

            //显示桌子
            List<TableModel> tableModelList = platService.getAllTableByGameAndRoom(roomName, gameName);
            ViewBag.roomSize = tableModelList.Count;
            ViewBag.roomList = tableModelList;
            return View();
        }



        public ActionResult RoomEdit()
        {
            return View();
        }



        public ActionResult Game()
        {
            return View();
        }
    }
}
