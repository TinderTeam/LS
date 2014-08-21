using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserModel
    {
        private String permission;

        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        private String userID;

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}