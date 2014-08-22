using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Util
{
    public class RandomService
    {
        public string getStringNumRandom(){
            string str="";
            int i = new Random().Next();
            return str;
        }
    }
}