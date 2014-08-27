using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class ScoreLog
    {
        private long logID;
        private String userName;
        private DateTime recordTime;
        private int value;
        private int balance;
        private String mode;
        private long gamblingPartyID;
        private long roundID;
        private String otherName;

        public long LogID
        {
            get { return logID; }
            set { logID = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public DateTime RecordTime
        {
            get { return recordTime; }
            set { recordTime = value; }
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public String Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public long GamblingPartyID
        {
            get { return gamblingPartyID; }
            set { gamblingPartyID = value; }
        }

        public long RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }



        public String OtherName
        {
            get { return otherName; }
            set { otherName = value; }
        }     

    }
}