using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{

    /// <summary>
    /// 游戏表
    /// </summary>
    public class Game
    {
        private string gameName;
        private string gameStatus;
        private string os;
        private string browser;
        private float taxRate;
        private int allRoomLimit;
        private int onePersonRoomLimit;
        private int oneRoomTableLimit;
        private int oneTablePersonLimit;
        private int bankerSelectNumTimeLimit;
        private int playerSelectNumTimeLimit;

        public string GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }


        public string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public string Browser
        {
            get { return browser; }
            set { browser = value; }
        }
     
        public float TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }
   
        public int AllRoomLimit
        {
            get { return allRoomLimit; }
            set { allRoomLimit = value; }
        }
    
        public int OnePersonRoomLimit
        {
            get { return onePersonRoomLimit; }
            set { onePersonRoomLimit = value; }
        }
  
        public int OneRoomTableLimit
        {
            get { return oneRoomTableLimit; }
            set { oneRoomTableLimit = value; }
        }
  
        public int OneTablePersonLimit
        {
            get { return oneTablePersonLimit; }
            set { oneTablePersonLimit = value; }
        }
   
        public int BankerSelectNumTimeLimit
        {
            get { return bankerSelectNumTimeLimit; }
            set { bankerSelectNumTimeLimit = value; }
        }

        public int PlayerSelectNumTimeLimit
        {
            get { return playerSelectNumTimeLimit; }
            set { playerSelectNumTimeLimit = value; }
        }
    }

}