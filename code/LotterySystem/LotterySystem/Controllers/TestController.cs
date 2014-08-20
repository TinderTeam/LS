using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using LotterySystem.Filters;
using LotterySystem.Models;

namespace LotterySystem.Controllers
{

    public class TestController : Controller
    {
        public ActionResult Test()
        {
            ViewBag.Send = "发送出去的参数";
            return View(); 
        }
      
    }
}
