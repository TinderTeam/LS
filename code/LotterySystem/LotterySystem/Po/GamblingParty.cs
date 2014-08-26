using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class GamblingParty
    {

        private long gamblingPartyID;
        private String gameName;
        private String roomName;
        private int tableNum;
        private String banker;
        private DateTime bankerStartTime;
        private DateTime bankerEndTime;

        public long GamblingPartyID
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
        public int TableNum
        {
            get { return tableNum; }
            set { tableNum = value; }
        }
        public String Banker
        {
            get { return banker; }
            set { banker = value; }
        }
        public DateTime BankerStartTime
        {
            get { return bankerStartTime; }
            set { bankerStartTime = value; }
        }
        public DateTime BankerEndTime
        {
            get { return bankerEndTime; }
            set { bankerEndTime = value; }
        }

    }
}