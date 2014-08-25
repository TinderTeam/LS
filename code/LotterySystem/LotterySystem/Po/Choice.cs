using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Choice
    {
        private String gameID;
        private String roundID;
        private int selectedNum;
        private DateTime startTime;   
        private DateTime endTime;


        public String GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        public String RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }
        public int SelectedNum
        {
            get { return selectedNum; }
            set { selectedNum = value; }
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