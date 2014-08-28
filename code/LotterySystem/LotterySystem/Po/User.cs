using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Po

{

    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        private int userID;
       
        private String userName;
        private String password;
        private String payPassword;
        private String permission="普通,";
        private String status;
        private String recommendUserName;
        private int account;

        public virtual int Account
        {
            get { return account; }
            set { account = value; }
        }

        public virtual String RecommendUserName
        {
            get { return recommendUserName; }
            set { recommendUserName = value; }
        }

        public virtual String Status
        {
            get { return status; }
            set { status = value; }
        }

        public virtual String PayPassword
        {
            get { return payPassword; }
            set { payPassword = value; }
        }


        public virtual String Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        public virtual String Password
        {
            get { return password; }
            set { password = value; }
        }

        public virtual int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public virtual String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}