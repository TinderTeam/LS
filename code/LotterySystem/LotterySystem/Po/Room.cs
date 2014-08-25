using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Room
    {
        private String gameName;
        private String roomName;
        private String roomPassword;
        private String roomHost;
        private String status;
        private int accessAcountLimit;
        private int basicPoint;
        private int amplification;
        private int bankerLimit;

        public String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }

        public int BankerLimit
        {
            get { return bankerLimit; }
            set { bankerLimit = value; }
        }


        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }

        }

        public String RoomPassword
        {
            get { return roomPassword; }
            set { roomPassword = value; }
        }

        public String RoomHost
        {
            get { return roomHost; }
            set { roomHost = value; }
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public int AccessAcountLimit
        {
            get { return accessAcountLimit; }
            set { accessAcountLimit = value; }
        }

        public int BasicPoint
        {
            get { return basicPoint; }
            set { basicPoint = value; }
        }

        public int Amplification
        {
            get { return amplification; }
            set { amplification = value; }
        }

    }
}