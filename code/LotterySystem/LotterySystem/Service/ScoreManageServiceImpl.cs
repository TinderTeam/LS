using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Dao;
using LotterySystem.Models;
 

namespace LotterySystem.Service
{
    public class ScoreManageServiceImpl : ScoreManageService
    {
        private ScoreLogDao scoreLogDao = DaoContext.getInstance().getScoreLogDao();
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private UserDao userDao = DaoContext.getInstance().getUserDao();
        public List<ScoreLog> getApprovalScoreList(String userName)
        {
            List<ScoreLog> logList = scoreLogDao.getApprovalScoreByUser(userName,SysConstants.SCORE_APPROVE_IN);
            return logList;
        }
        public List<ScoreLog> getRepayScoreList(String userName)
        {
            List<ScoreLog> logList = scoreLogDao.getApprovalScoreByUser(userName, SysConstants.SCORE_LEND_OUT);
            return logList;
        }

        public List<ScoreLog> getScoreList(String userName)
        {
            List<ScoreLog> logList = scoreLogDao.getScoreListByUser(userName);

            return logList;
        }
        public void ApproveScore(ApproveScoreModel model,String userName)
        {
            if (null == model)
            {
                log.Error("approve score is not right ");
                throw new SystemException(ErrorMsgConst.OPERATE_FAILED);
            }
            User lendUser = userDao.getSystemUserByName(model.UserName);
            if (null == lendUser)
            {
                throw new SystemException(ErrorMsgConst.USER_NOT_EXITED);
            }
            if (lendUser.UserID != model.UserID)
            {
                throw new SystemException(ErrorMsgConst.USER_NOT_MATCH);
            }


            ScoreLog score = new ScoreLog();

            User user = userDao.getSystemUserByName(userName);
            score.UserName = user.UserName;
            score.RecordTime = DateTime.Now;
            score.Value = model.ScoreValue;
            score.Balance = user.Account;
            score.Mode = SysConstants.SCORE_APPROVE_IN;

            score.OtherName = model.UserName;

            scoreLogDao.creatScoreLog(score);
        }

        public void handleLendScore(int logID,bool isAgree)
        {
            ScoreLog  score = scoreLogDao.getScoreByID(logID);

            if (null == score)
            {
                log.Error("can not find score by log id .log id" + logID);
                return;
            }

            User lendOutUser = userDao.getSystemUserByName(score.OtherName);
            int scoreValue = 0;
            if (isAgree)
            {
                scoreValue = score.Value;
                if (score.Value > lendOutUser.Account)
                {
                    throw new SystemException(ErrorMsgConst.BALANCE_NOT_ENOUGH);
                }
            }

            lendOutUser.Account -= scoreValue;

            ScoreLog lendOut = new ScoreLog();

            lendOut.Balance = lendOutUser.Account;
            lendOut.Value = scoreValue;
            lendOut.UserName = score.OtherName;
            lendOut.OtherName = score.UserName;
            lendOut.Mode = SysConstants.SCORE_LEND_OUT;
            lendOut.RecordTime = DateTime.Now;


            User borrowInUser = userDao.getSystemUserByName(score.UserName);
            borrowInUser.Account += scoreValue;
            ScoreLog borrowIn = new ScoreLog();
            borrowIn.Balance = borrowInUser.Account;
            borrowIn.Value = scoreValue;
            borrowIn.UserName = score.UserName;
            borrowIn.OtherName = score.OtherName;
            borrowIn.Mode = SysConstants.SCORE_BORROW_IN;
            borrowIn.RecordTime = DateTime.Now;


            userDao.updateUser(borrowInUser);
            userDao.updateUser(lendOutUser);
 
            scoreLogDao.creatScoreLog(lendOut);
            scoreLogDao.creatScoreLog(borrowIn);

            score.GamblingPartyID = Convert.ToString(lendOut.LogID);
            scoreLogDao.updateScoreLog(score);
            

        }


        public void handleRepayScore(int logID)
        {
            ScoreLog score = scoreLogDao.getScoreByID(logID);

            if (null == score)
            {
                log.Error("can not find score by log id .log id" + logID);
                return;
            }

            int scoreValue = score.Value;

            User repayOutUser = userDao.getSystemUserByName(score.OtherName);
            if (score.Value > repayOutUser.Account)
            {
                throw new SystemException(ErrorMsgConst.BALANCE_NOT_ENOUGH);
            }

            repayOutUser.Account -= scoreValue;


            ScoreLog repayOut = new ScoreLog();

            repayOut.Balance = repayOutUser.Account;
            repayOut.Value = scoreValue;
            repayOut.UserName = score.OtherName;
            repayOut.OtherName = score.UserName;
            repayOut.Mode = SysConstants.SCORE_REPAY_OUT;
            repayOut.RecordTime = DateTime.Now;


            User repayIntUser = userDao.getSystemUserByName(score.UserName);
            repayIntUser.Account += scoreValue;
            ScoreLog repayIn = new ScoreLog();
            repayIn.Balance = repayIntUser.Account;
            repayIn.Value = scoreValue;
            repayIn.UserName = score.UserName;
            repayIn.OtherName = score.OtherName;
            repayIn.Mode = SysConstants.SCORE_REPAY_IN;
            repayIn.RecordTime = DateTime.Now;


            userDao.updateUser(repayOutUser);
            userDao.updateUser(repayIntUser);

            scoreLogDao.creatScoreLog(repayOut);
            scoreLogDao.creatScoreLog(repayIn);

            score.GamblingPartyID = Convert.ToString(repayOut.LogID);
            scoreLogDao.updateScoreLog(score);


        }
    }
}