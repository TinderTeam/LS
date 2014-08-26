using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Util;
namespace LotterySystem.Models
{
    public class TableModel
    {

        private String gamblingPartyID;
        private String gameName;
        private String roomName;
        private int tabelNo;
        private String banker;
        private DateTime bankerStartTime;
        private String bankerStartTimeStr;     
        private DateTime bankerEndTime;
        private String bankerEndTimeStr;     
        private int playerNum;

        public String BankerStartTimeStr
        {
            get { return bankerStartTimeStr; }
            set { bankerStartTimeStr = value; }
        }
        public String BankerEndTimeStr
        {
            get { return bankerEndTimeStr; }
            set { bankerEndTimeStr = value; }
        }
        public DateTime BankerStartTime
        {
            get { return bankerStartTime; }
            set 
            {
                bankerStartTime = value;
                String timeStr;
                if (bankerStartTime.Year < 2000)
                {
                    timeStr = "";
                }
                else
                {
                    timeStr = DateTimeServcie.getShotTimeStr(bankerStartTime);
                }
                BankerStartTimeStr = timeStr;
            }
        }
        public DateTime BankerEndTime
        {
            get { return bankerEndTime; }
            set {
                bankerEndTime = value;
                String timeStr;
                if (bankerEndTime.Year < 2000)
                {
                    timeStr = "";
                }
                else
                {
                    timeStr = DateTimeServcie.getShotTimeStr(bankerEndTime);
                }
                BankerEndTimeStr = timeStr;
            }
        }

        public String GamblingPartyID
        {
            get { return gamblingPartyID; }
            set { gamblingPartyID = value; }
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
        public String Banker
        {
            get { return banker; }
            set { banker = value; }
        }

        public int PlayerNum
        {
            get { return playerNum; }
            set { playerNum = value; }
        }

    
    }
}