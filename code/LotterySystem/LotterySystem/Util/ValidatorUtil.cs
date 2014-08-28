using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Util
{
    public class ValidatorUtil
    {
        public static bool isEmpty(String str)
        {
            if(null == str )
            {
                return true;
            }
            if(0 == str.Length)
            {
                return true;
            }
            return false;
        }


    }
}