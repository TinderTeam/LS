using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
namespace LotterySystem.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Hall()
        {
            if ((UserModel)Session["SystemUser"] != null)
            {
                ViewBag.User = (UserModel)Session["SystemUser"];
            }

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

        public ActionResult RoomPage()
        {
            return View();
        }
        public ActionResult GamePage()
        {
            return View();
        }
    }
}
