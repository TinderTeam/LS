using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class SystemInfoModel
    {
    }

    public class GameInfoModel
    {
        private int gameID;
        private String gameName;


        public int GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }


        public String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }

    }
}