using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface SysDao
    {
        long getMaxPlayer();
        void setMaxPlayer(long i);

        String getOS();
        void setOS(String os);

        String getBorowser();
        void setBorowser(String borowser);

        int getRegistType();
        void setRegistType(int type);
    }
}