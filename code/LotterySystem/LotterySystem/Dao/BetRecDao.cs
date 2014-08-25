using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Dao
{
    public interface BetRecDao
    {
        List<BetRec> getAll();
        BetRec getBetRecByUserName(String userName);
        void creatBetRec(BetRec betRec);
        void deleteBetRecByUserName(String userName);
        void updateBetRec(BetRec betRec);


    }
}