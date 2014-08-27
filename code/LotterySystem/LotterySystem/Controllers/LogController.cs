using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Service;
using LotterySystem.Po;
namespace LotterySystem.Controllers
{
    public class LogController : Controller
    {

        LogService manageService = ServiceContext.getInstance().getLogService();

        
        public ActionResult LoginLog()
        {
            List<LoginLog> logList = manageService.getLoginLogList();
            ViewBag.LoginLogList = logList;
            ViewBag.LoginLogListCount = logList.Count;
            return View();     
        }

        public ActionResult ScoreLog()
        {
            List<ScoreLog> logList = manageService.getScoreLogList();
            ViewBag.ScoreLogList = logList;
  
            return View();
        }
    }
}
