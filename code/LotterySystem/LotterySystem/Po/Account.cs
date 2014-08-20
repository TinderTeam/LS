using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Domain
{

    /// <summary>
    /// 用户
    /// </summary>
    public class Account
    {
        private String userID;
        private float accountValue;

        public float AccountValue
        {
            get { return accountValue; }
            set { accountValue = value; }
        }

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }

    }
}