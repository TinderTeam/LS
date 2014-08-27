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

        public virtual long LogID
        {
            get { return logID; }
            set { logID = value; }
        }

        public virtual String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public virtual DateTime RecordTime
        {
            get { return recordTime; }
            set { recordTime = value; }
        }

        public virtual int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public virtual int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public virtual String Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public virtual long GamblingPartyID
        {
            get { return gamblingPartyID; }
            set { gamblingPartyID = value; }
        }

        public virtual long RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }



        public virtual String OtherName
        {
            get { return otherName; }
            set { otherName = value; }
        }     

    }
}