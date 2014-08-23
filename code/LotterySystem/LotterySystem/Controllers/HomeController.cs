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
    public class HomeController : Controller
    {
        PlatService platService = ServiceContext.getInstance().getPlatService();

        public ActionResult Index()
        {

            if ((UserModel)Session["SystemUser"] != null)
            {
                ViewBag.User = (UserModel)Session["SystemUser"];            
            }
            ViewBag.GameList = platService.getGameList();
            ViewBag.GameListCount = platService.getGameList().Count;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
