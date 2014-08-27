using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Dao;
 

namespace LotterySystem.Service
{
    public class ScoreManageServiceImpl : ScoreManageService
    {
        private ScoreLogDao scoreLogDao = DaoContext.getInstance().getScoreLogDao();
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ScoreLog> getApprovalScoreList(String userName)
        {
            List<ScoreLog> logList = scoreLogDao.getApprovalScoreByUser(userName);
            return logList;
        }
        public List<ScoreLog> getRepayScoreList(String userName)
        {
            List<ScoreLog> logList = scoreLogDao.getRepayScoreByUser(userName);
            return logList;
        }
    }
}