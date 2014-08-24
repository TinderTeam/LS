using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LotterySystem.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserAccount()
        {
            return View();
        }
        public ActionResult UserInfo()
        {
            return View();
        }
    }
}
