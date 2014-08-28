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

        ScoreLog getScoreByID(long logID);
        List<ScoreLog> getApprovalScoreByUser(String userName, String mode);
    
        void updateScoreLog(ScoreLog score);
        void creatScoreLog(ScoreLog log);
 
        
    }
}