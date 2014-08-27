using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace LotterySystem.Models
{
    public class LoginLogModel
    {

        private String userName;
        private DateTime loginTime;
        private String result;
        private String os;
        private String browser;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
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