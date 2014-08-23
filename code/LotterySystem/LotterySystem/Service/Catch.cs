using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem
{
    public  class SysCatch
    {
        private static long onlinePlayerNum;

        public static long OnlinePlayerNum
        {
            get { return SysCatch.onlinePlayerNum; }
            set { SysCatch.onlinePlayerNum = value; }
        }

    }
}