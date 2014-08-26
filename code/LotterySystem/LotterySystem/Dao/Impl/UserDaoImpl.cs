using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao
{
    public class UserDaoImpl:UserDao
    {
        public User getSystemUserByName(string userName)
        {

            return UserStub.getStubUser();
        }
        public void createUser(User user)
        {

        }
    }
}