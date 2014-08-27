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

        public virtual string GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }


        public virtual string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public virtual string Os
        {
            get { return os; }
            set { os = value; }
        }

        public virtual string Browser
        {
            get { return browser; }
            set { browser = value; }
        }

        public virtual float TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }

        public virtual int AllRoomLimit
        {
            get { return allRoomLimit; }
            set { allRoomLimit = value; }
        }

        public virtual int OnePersonRoomLimit
        {
            get { return onePersonRoomLimit; }
            set { onePersonRoomLimit = value; }
        }

        public virtual int OneRoomTableLimit
        {
            get { return oneRoomTableLimit; }
            set { oneRoomTableLimit = value; }
        }

        public virtual int OneTablePersonLimit
        {
            get { return oneTablePersonLimit; }
            set { oneTablePersonLimit = value; }
        }

        public virtual int BankerSelectNumTimeLimit
        {
            get { return bankerSelectNumTimeLimit; }
            set { bankerSelectNumTimeLimit = value; }
        }

        public virtual int PlayerSelectNumTimeLimit
        {
            get { return playerSelectNumTimeLimit; }
            set { playerSelectNumTimeLimit = value; }
        }
    }

}