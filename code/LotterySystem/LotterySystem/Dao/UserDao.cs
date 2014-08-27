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

         void createUser(User user);
         void deleteUserByUserName(String userName);
         void updateUser(User user);
         User getSystemUserByName(string userName);
         List<User> getApprovalUserListByRecomName(String recomName);
         List<User> getSystemUserByFilter(string userName);

    }

}