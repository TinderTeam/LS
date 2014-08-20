using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Domain
{
    public class LoginLog
    {
        private String userID;
        private DateTime loginTime;
        private String result;
        private String os;
        private String browser;


        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public DateTime LoginTime
        {
            get { return loginTime; }
            set { loginTime = value; }
        }
        public String Result
        {
            get { return result; }
            set { result = value; }
        }
        public String Os
        {
            get { return os; }
            set { os = value; }
        }
        public String Browser
        {
            get { return browser; }
            set { browser = value; }
        }

    }
}