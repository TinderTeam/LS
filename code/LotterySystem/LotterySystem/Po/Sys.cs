using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Sys
    {
        private int maxPlayer;

        private string registType;

        public  virtual int MaxPlayer
        {
            get { return maxPlayer; }
            set { maxPlayer = value; }
        }

        public virtual string RegistType
        {
            get { return registType; }
            set { registType = value; }
        }

        


    }
}