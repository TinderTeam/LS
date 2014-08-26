using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using NHibernate;
namespace LotterySystem.Dao
{
    public interface UserDao
    {
        User getSystemUserByName(string userName);

        void createUser(User user);
       


    }
}