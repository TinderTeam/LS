using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class GamblingParty
    {

        private int gamblingPartyID;
        private String gameName;
        private String roomName;
        private int tableNum;
        private String banker;
        private String bankerStartTime;
        private String bankerEndTime;

        public int GamblingPartyID
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
        public String BankerStartTime
        {
            get { return bankerStartTime; }
            set { bankerStartTime = value; }
        }
        public String BankerEndTime
        {
            get { return bankerEndTime; }
            set { bankerEndTime = value; }
        }

    }
}