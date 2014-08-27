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

        public virtual long GamblingPartyID
        {
            get { return gamblingPartyID; }
            set { gamblingPartyID = value; }
        }
        public virtual String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public virtual String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public virtual int TableNum
        {
            get { return tableNum; }
            set { tableNum = value; }
        }
        public virtual String Banker
        {
            get { return banker; }
            set { banker = value; }
        }
        public virtual DateTime BankerStartTime
        {
            get { return bankerStartTime; }
            set { bankerStartTime = value; }
        }
        public virtual DateTime BankerEndTime
        {
            get { return bankerEndTime; }
            set { bankerEndTime = value; }
        }

    }
}