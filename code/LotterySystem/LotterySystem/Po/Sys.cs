using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Sys
    {
        private long maxPlayer;

        public long MaxPlayer
        {
            get { return maxPlayer; }
            set { maxPlayer = value; }
        }
        private String os;

        public String Os
        {
            get { return os; }
            set { os = value; }
        }
        private String browser;

        public String Browser
        {
            get { return browser; }
            set { browser = value; }
        }
        private int registType;

        public int RegistType
        {
            get { return registType; }
            set { registType = value; }
        }


    }
}