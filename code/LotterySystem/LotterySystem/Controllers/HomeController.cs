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

        public ActionResult Index(String msg)
        {
            ViewBag.Msg = msg;
            return View();
        }

       public ActionResult SystemManage()
       {
           return View();
       }
    }
}
