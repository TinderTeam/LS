using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class BetRec
    {
        private int gameID;
        private int roundID;
        private String userName;
        private String cathecticType;
        private int cathecticTP;
        private int pointA;
        private int pointB;
        private int pointC;

        public int GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        public int RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public String CathecticType
        {
            get { return cathecticType; }
            set { cathecticType = value; }
        }
        public int CathecticTP
        {
            get { return cathecticTP; }
            set { cathecticTP = value; }
        }
        public int PointA
        {
            get { return pointA; }
            set { pointA = value; }
        }
        public int PointB
        {
            get { return pointB; }
            set { pointB = value; }
        }
        public int PointC
        {
            get { return pointC; }
            set { pointC = value; }
        }
    }
}