using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao
{
    public class SysDaoImpl : SysDao
    {
        public long getMaxPlayer() {
            //Stub
            return DBStub.getDBStub().getSys().MaxPlayer;
        }

        public void setMaxPlayer(long i)
        {
            DBStub.getDBStub().getSys().MaxPlayer = i;
        }

        public String getOS()
        {
            //Stub
            return DBStub.getDBStub().getSys().Os;
        }
        public void setOS(String os)
        {
            //Stub
            DBStub.getDBStub().getSys().Os = os;
        }


        public String getBorowser()
        {
            //Stub
            return DBStub.getDBStub().getSys().Browser;
        }
        public void setBorowser(String browser)
        {
            //Stub
            DBStub.getDBStub().getSys().Browser = browser;
        }

        public int getRegistType()
        {
            //Stub
            return DBStub.getDBStub().getSys().RegistType;
        }
        public void setRegistType(int type)
        {
            //Stub
            DBStub.getDBStub().getSys().RegistType = type;
        }
    }
}