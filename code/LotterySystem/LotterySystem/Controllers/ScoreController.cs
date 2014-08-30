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
    public class ScoreController : BaseController
    {
        private ScoreManageService scoreService = ServiceContext.getInstance().getScoreManageService();
        LogService logService = ServiceContext.getInstance().getLogService();
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private String errorMsg = null;

        public ActionResult ScoreRecord(String msg)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            ViewBag.ScoreLogList = scoreService.getScoreList(user.UserName);
  
            return View();
        }


        public ActionResult ScoreManage(String msg)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            ViewBag.ApproveScoreList = scoreService.getApprovalScoreList(user.UserName);
            ViewBag.RepayScoreList = scoreService.getRepayScoreList(user.UserName);

            ViewBag.ErrorMsg = msg;
            return View();
        }

        [HttpPost]
        public ActionResult ApproveScore(ApproveScoreModel model, string submit)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            try
            {
                if (SysConstants.SCORE_APPROVE_IN.Equals(submit))
                {
                    scoreService.approveScore(model, user.UserName);
                }
                else
                {
                    scoreService.sendScore(model, user.UserName);
                }

                this.errorMsg = ErrorMsgConst.OPERATE_SUCCESS;
            }
            catch (SystemException ex)
            {
                log.Error("agree lend failed ", ex);
                this.errorMsg = ex.Message;
            }

            return RedirectToAction("ScoreManage", "Score", new { msg = this.errorMsg });
        }
        [HttpPost]
 
        public ActionResult SendScore(ApproveScoreModel model)
        {
            UserModel user = (UserModel)Session["SystemUser"];
            try
            {
                scoreService.sendScore(model, user.UserName);
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
                scoreService.handleLendScore(logID, false);
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
                scoreService.handleLendScore(logID, true);
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
                scoreService.handleRepayScore(logID);
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
