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
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private String errorMsg = null;
        public ActionResult ScoreManage(String msg)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            ViewBag.ApproveScoreList = userService.getApprovalScoreList(user.UserName);
            ViewBag.RepayScoreList = userService.getRepayScoreList(user.UserName);

            ViewBag.ErrorMsg = msg;
            return View();
        }
        [HttpPost]
        public ActionResult ApproveScore(ApproveScoreModel model)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            try
            {
                userService.ApproveScore(model, user.UserName);
                this.errorMsg = ErrorMsgConst.OPERATE_SUCCESS;
            }
            catch (SystemException ex)
            {
                log.Error("agree lend failed ", ex);
                this.errorMsg = ex.Message;
            }

            return RedirectToAction("ScoreManage", "Score", new { msg = this.errorMsg });
        }
     
        public ActionResult Refuse(int logID)
        {
            try
            {
                userService.handleLendScore(logID, false);
                this.errorMsg = ErrorMsgConst.OPERATE_SUCCESS;
            }
            catch (SystemException ex)
            {
                log.Error("agree lend failed ", ex);
                this.errorMsg = ex.Message;
            }

            return RedirectToAction("ScoreManage", "Score", new { msg = this.errorMsg });
        }
         
        public ActionResult Agree(int logID)
        {
            try
            {
                userService.handleLendScore(logID, true);
                this.errorMsg = ErrorMsgConst.OPERATE_SUCCESS;
            }
            catch (SystemException ex)
            {
                log.Error("agree lend failed ",ex);
                this.errorMsg = ex.Message;
            }

            return RedirectToAction("ScoreManage", "Score", new { msg = this.errorMsg });
        }
       
        public ActionResult Repay(int logID)
        {
            try
            {
                userService.handleRepayScore(logID);
                this.errorMsg = ErrorMsgConst.OPERATE_SUCCESS;
            }
            catch (SystemException ex)
            {
                log.Error("agree lend failed ", ex);
                this.errorMsg = ex.Message;
            }

            return RedirectToAction("ScoreManage", "Score", new { msg = this.errorMsg });
        }
       

    }
}
