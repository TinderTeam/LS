using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserModel
    {
        private String userID;
        private String userName;
        private String permission;
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }

    public class UserInfoModel
    {
    }

    public class UserAccountModel
    {
    }
}