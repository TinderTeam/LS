using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class LoginLog
    {
        private int logID;
 
        private String userName;
        private DateTime loginTime;
        private String result;
        private String os;
        private String browser;

        public virtual int LogID
        {
            get { return logID; }
            set { logID = value; }
        }

        public virtual String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public virtual DateTime LoginTime
        {
            get { return loginTime; }
            set { loginTime = value; }
        }
        public virtual String Result
        {
            get { return result; }
            set { result = value; }
        }
        public virtual String Os
        {
            get { return os; }
            set { os = value; }
        }
        public virtual String Browser
        {
            get { return browser; }
            set { browser = value; }
        }

    }
}