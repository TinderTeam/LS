using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Service;
using LotterySystem.Models;
using LotterySystem.Po;

namespace LotterySystem.Controllers
{
    public class ScoreController : Controller
    {
        private ScoreManageService userService = ServiceContext.getInstance().getScoreManageService();
        LogService logService = ServiceContext.getInstance().getLogService();

        public ActionResult ScoreManage()
        {
            UserModel user = (UserModel)Session["SystemUser"];
            ViewBag.ApproveScoreList = userService.getApprovalScoreList(user.UserName);
            ViewBag.RepayScoreList = userService.getRepayScoreList(user.UserName);
            return View();
        }
        [HttpPost]
        public ActionResult ApproveScore(ApproveScoreModel model)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            ScoreLog log = new ScoreLog();
            log.UserName = user.UserName;
            log.RecordTime = DateTime.Now;
            log.Value = model.ScoreValue;
            log.Balance = user.BalanceScore;
            log.Mode = SysConstants.SCORE_APPROVE_IN;

            log.OtherName = model.UserName;
            logService.recordScoreLog(log);
            return View();
        }
     
        public ActionResult Refuse(int logID)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agree(int logID)
        {
            return View();
        }
       
        public ActionResult Repay(int logID)
        {
            return View();
        }
       

    }
}
