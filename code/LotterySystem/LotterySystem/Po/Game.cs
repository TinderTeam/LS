using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Game
    {
        private int gameID;
        private String gameName;
        private String roomName;
        private int tabelNo;
        private String bankerID;
        private DateTime startTime;
        private DateTime endTime;


        public int GameID
        {
            get { return gameID; }
            set { gameID = value; }
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
       
        public int TabelNo
        {
            get { return tabelNo; }
            set { tabelNo = value; }
        }
      
        public String BankerID
        {
            get { return bankerID; }
            set { bankerID = value; }
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