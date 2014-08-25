using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{

    /// <summary>
    /// 用户
    /// </summary>
    public class Account
    {
        private String userName;
        private int accountValue;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int AccountValue
        {
            get { return accountValue; }
            set { accountValue = value; }
        }


    }
}