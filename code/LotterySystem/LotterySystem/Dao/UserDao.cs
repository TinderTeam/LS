using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao
{
    public class UserDao
    {
        public SystemUser getSystemUserByID(string id)
        {
            
            /*
             * Stub Test
             * 
             */
            return UserStub.getStubUser() ;
        }
    }
}