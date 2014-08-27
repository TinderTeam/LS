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

        void creatScoreLog(ScoreLog log);
 
        
    }
}