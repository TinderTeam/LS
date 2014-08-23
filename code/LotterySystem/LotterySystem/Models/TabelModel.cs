using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Util;
namespace LotterySystem.Models
{
    public class TableModel
    {
        private int gameID;
        private String gameName;
        private String roomName;
        private int tabelNo;
        private String bankerID;
        private String bankerName;
        private DateTime startTime;
        private DateTime endTime;



        public String StartTimeStr
        {
            get { return DateTimeServcie.getShotTimeStr(StartTime); }
           
        }
       

        public String EndTimeStr
        {
            get { return DateTimeServcie.getShotTimeStr(EndTime); }
           
        }



        public String BankerName
        {
            get { return bankerName; }
            set { bankerName = value; }
        }
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

        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public int TabelNo
        {
            get { return tabelNo; }
            set { tabelNo = value; }
        }

        public String BankerID
        {
            get { return bankerID; }
            set { bankerID = value; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }


        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}