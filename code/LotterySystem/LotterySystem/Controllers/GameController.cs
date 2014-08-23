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


        public ActionResult RoomList(String gameName)
        {     
            //将Game放入Session
            Session["CurrentGame"] = platService.getGameByName(gameName);
            //获取当前登录用户
            UserModel user=(UserModel)Session["SystemUser"];

            //显示房间
            List<RoomModel> roomList = platService.getOpenRoomListByGameName(gameName);
            ViewBag.roomSize = roomList.Count;
            ViewBag.roomList = roomList;
            return View();
        }

        public ActionResult TableList(String roomName)
        {
            //将Room放入Session
            Session["CurrentRoom"] = platService.getRoomByName(roomName);
            //获取Session信息
            UserModel user = (UserModel)Session["SystemUser"];
            String gameName=(String)Session["CurrentGame"];

            //显示桌子
            List<TableModel> tableModelList = platService.getAllTableByGameAndRoom(roomName, gameName);
            ViewBag.roomSize = tableModelList.Count;
            ViewBag.roomList = tableModelList;
            return View();
        }

        public ActionResult EnterRoom()
        {
            return RedirectToAction("RoomPage", "Game");
        }

        public ActionResult EnterGame()
        {
            return RedirectToAction("GamePage", "Game");
        }

       
        public ActionResult Game()
        {
            return View();
        }

    }
}
