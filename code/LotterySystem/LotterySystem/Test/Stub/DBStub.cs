
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Test.Stub
{

  

    public  class DBStub
    {
        private static  DBStub dbStub;

        private Sys sys;

      
        public static DBStub getDBStub()
        {
            if(dbStub==null){
                dbStub=new DBStub();
            }
            return dbStub;
        }

        public Sys getSys()
        {
            if (sys == null)
            {
                sys = new Sys();
                sys.Browser = "";
                sys.MaxPlayer = 10;
                sys.Os = "";
                sys.RegistType = 2;
            }
            return sys;
        }

        public Sys Sys
        {
            get { return sys; }
            set { sys = value; }
        }

    }

}