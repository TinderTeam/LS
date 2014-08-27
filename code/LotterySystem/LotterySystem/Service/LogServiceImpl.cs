using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Dao;
 

namespace LotterySystem.Service
{
    public class LogServiceImpl : LogService
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<LoginLog> getLoginLogList()
        {
            List<LoginLog> logList = DaoContext.getInstance().getLoginLogDao().getAll();
            return logList;
        }

        public void recordLoginLog(String userName,String result,String os,String browser)
        {
            
            LoginLog loginLog = new LoginLog();
            loginLog.UserName = userName;
            loginLog.LoginTime = DateTime.Now;
            loginLog.Result = result;
            loginLog.Os = os;
            loginLog.Browser = browser;
            DaoContext.getInstance().getLoginLogDao().creatLoginLog(loginLog);


        }

        public List<ScoreLog> getScoreLogList()
        {
            List<ScoreLog> logList = DaoContext.getInstance().getScoreLogDao().getAll();
            return logList;
        }

        public void recordScoreLog(ScoreLog log)
        {

        }
    }
}