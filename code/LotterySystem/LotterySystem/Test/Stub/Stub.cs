using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Test.Stub
{
    public static class UserStub
    {
        public static SystemUser getStubUser()
        {
            SystemUser user = new SystemUser();
            user.UserID = "admin@123.com";
            user.UserName = "管理员";
            user.Password = "1234";
            user.PayPassword = "1234";
            user.Status = "OK";
            user.Permission = "all";
            return user;
        }
    }
}