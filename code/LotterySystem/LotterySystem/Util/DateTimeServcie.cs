using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Util
{
    public static  class DateTimeServcie
    {
        public static string getShotTimeStr(DateTime date){
            return date.ToShortTimeString().ToString();
        }
    }
}