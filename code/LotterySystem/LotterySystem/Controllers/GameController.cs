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
        public ActionResult Hall(String gameID)
        {
            if ((UserModel)Session["SystemUser"] != null)
            {
                //验证用户
                ViewBag.User = (UserModel)Session["SystemUser"];
                //显示房间
                RoomListModel roomList=platService.getRoomListByGameID(gameID);

                ViewBag.roomSize = roomList.RoomList.Count;
                ViewBag.roomList = roomList.RoomList;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }               
        }

        public ActionResult EnterRoom()
        {
            return RedirectToAction("RoomPage", "Game");
        }

        public ActionResult EnterGame()
        {
            return RedirectToAction("GamePage", "Game");
        }

        public ActionResult RoomPage()
        {
            return View();
        }
        public ActionResult GamePage()
        {
            return View();
        }

        public ActionResult TabelList()
        {
            return View();
        }
    }
}
