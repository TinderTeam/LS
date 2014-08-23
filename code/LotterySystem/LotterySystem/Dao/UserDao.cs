using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using NHibernate;
namespace LotterySystem.Dao
{
    public class UserDao
    {
        public User getSystemUserByID(string id)
        {
           
            return UserStub.getStubUser() ;
        }
        public void createUser(User user)
        {
           
        }

   
      

    }
}