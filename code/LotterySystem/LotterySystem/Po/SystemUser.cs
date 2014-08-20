using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po

{

    /// <summary>
    /// 用户
    /// </summary>
    public class SystemUser
    {
        private String userID;
        private String userName;
        private String password;
        private String payPassword;
        private String permission;
        private String status;
        private String recommendUserID;

        public String RecommendUserID
        {
            get { return recommendUserID; }
            set { recommendUserID = value; }
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public String PayPassword
        {
            get { return payPassword; }
            set { payPassword = value; }
        }


        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}