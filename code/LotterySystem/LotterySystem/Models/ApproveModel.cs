using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class ApproveScoreModel
    {
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private int scoreValue;

        public int ScoreValue
        {
            get { return scoreValue; }
            set { scoreValue = value; }
        }


    }
}