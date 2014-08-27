using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface ScoreLogDao
    {
        List<ScoreLog> getAll();

        List<ScoreLog> getApprovalScoreByUser(String userName);
        List<ScoreLog> getRepayScoreByUser(String userName);
     
        void creatScoreLog(ScoreLog log);
 
        
    }
}