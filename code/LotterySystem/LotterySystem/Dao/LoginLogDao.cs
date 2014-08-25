using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface LoginLogDao
    {
        List<LoginLog> getAll();
        LoginLog getLoginLogByUserName(String userName);
        void creatLoginLog(LoginLog loginLog);
        void deleteLoginLogByUserName(String userName);
        void updateLoginLog(LoginLog loginLog);
        
    }
}