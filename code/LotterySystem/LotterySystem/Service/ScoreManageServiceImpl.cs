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
        public void openAccount(String userName)
        {
            ScoreLog score = new ScoreLog();

            User user = userDao.getSystemUserByName(userName);
            score.UserName = user.UserName;
            score.RecordTime = DateTime.Now;
            score.Value = user.Account;
            score.Balance = user.Account;
            score.Mode = SysConstants.SCORE_USER_OPEN;
 
            scoreLogDao.creatScoreLog(score);
        }
        public void sendScore(ApproveScoreModel model, String userName)
        {
            checkUser(model, userName);
            User sendOutUser = userDao.getSystemUserByName(userName);
            scoreEnough(model.ScoreValue, sendOutUser);

            ScoreLog sendOutScore = new ScoreLog();
            sendOutUser.Account -= model.ScoreValue;
            sendOutScore.UserName = sendOutUser.UserName;
            sendOutScore.RecordTime = DateTime.Now;
            sendOutScore.Value = model.ScoreValue;
            sendOutScore.Balance = sendOutUser.Account;
            sendOutScore.Mode = SysConstants.SCORE_SEND_OUT;

            sendOutScore.OtherName = model.UserName;

            ScoreLog sendInScore = new ScoreLog();

            User sendInUser = userDao.getSystemUserByName(model.UserName);
            sendInUser.Account += model.ScoreValue;
            sendInScore.UserName = model.UserName; 
            sendInScore.RecordTime = DateTime.Now;
            sendInScore.Value = model.ScoreValue;
            sendInScore.Balance = sendInUser.Account;
            sendInScore.Mode = SysConstants.SCORE_SEND_IN;

            sendInScore.OtherName = sendInUser.UserName;

            userDao.updateUser(sendOutUser);
            userDao.updateUser(sendInUser);
            scoreLogDao.creatScoreLog(sendInScore);
            scoreLogDao.creatScoreLog(sendOutScore);


        }
        public void approveScore(ApproveScoreModel model,String userName)
        {
            checkUser(model, userName);


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

        private static void checkUser(ApproveScoreModel model, String userName)
        {
            if (null == model)
            {
                log.Error("approve score is not right ");
                throw new SystemException(ErrorMsgConst.OPERATE_FAILED);
            }
            if (userName.Equals(model.UserName))
            {
                log.Error("user name is yourself ");
                throw new SystemException(ErrorMsgConst.USER_NOT_SELF);
            }

            ServiceContext.getInstance().getUserService().isUserExist(model.UserID, model.UserName);
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

                scoreEnough(scoreValue, lendOutUser);
            }
            else
            {
                log.Info(" refuse apply ");
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

        private static void scoreEnough(int needScore, User user)
        {
            if (!user.Permission.Contains(SysConstants.PERSSION_OVER_DRAFT))
            {
                if (needScore > user.Account)
                {
                    throw new SystemException(ErrorMsgConst.BALANCE_NOT_ENOUGH);
                }
            }
            else
            {
                log.Info("the user have over draft function");
            }
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

            scoreEnough(scoreValue, repayOutUser);

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