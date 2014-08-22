using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
namespace LotterySystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if ((UserModel)Session["SystemUser"] != null)
            {
                ViewBag.User = (UserModel)Session["SystemUser"];
            }

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
    }
}
