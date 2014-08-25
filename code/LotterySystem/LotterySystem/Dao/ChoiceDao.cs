using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface ChoiceDao
    {
        List<Choice> getAll();
        Choice getChoiceByRoundID(String roundID);
        void creatChoice(Choice choice);
        void deleteChoiceByRoundID(String roundID);
        void updateChoice(Choice choice);

    }
}