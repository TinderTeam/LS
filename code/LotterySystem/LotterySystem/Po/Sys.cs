using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Sys
    {
        private long maxPlayer;
        private String os;
        private String browser;
        private int registType;

        public long MaxPlayer
        {
            get { return maxPlayer; }
            set { maxPlayer = value; }
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
  
        public int RegistType
        {
            get { return registType; }
            set { registType = value; }
        }


    }
}