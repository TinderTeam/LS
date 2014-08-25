using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class RoomModel
    {
        private String gameName;
        private String roomName;
        private String roomPassword;
        private String roomHost;

      
        private String status;
        private int accessAcountLimit;
        private int basicPoint;
        private int amplification;
        private int bankerPointLimited;
        private int bankerLimit;

        public int BankerLimit
        {
            get { return bankerLimit; }
            set { bankerLimit = value; }
        }


        public String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }


        public String RoomHost
        {
            get { return roomHost; }
            set { roomHost = value; }
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

        public int BankerPointLimited
        {
            get { return bankerPointLimited; }
            set { bankerPointLimited = value; }
        }

        

    }

    public class RoomForm
    {

        private String gameName;
        private String roomName;
        private String roomPassword;
        private String status;
        private int accessAcountLimit;
        private int bankerPointLimited;
        private int basicPoint;
        private int amplification;
        private String writeNameStr;
        private String blackNameStr;
        private int bankerLimit;

        public int BankerLimit
        {
            get { return bankerLimit; }
            set { bankerLimit = value; }
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
      
        public String RoomPassword
        {
            get { return roomPassword; }
            set { roomPassword = value; }
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
       
        public int BankerPointLimited
        {
            get { return bankerPointLimited; }
            set { bankerPointLimited = value; }
        }
     
        public String WriteNameStr
        {
            get { return writeNameStr; }
            set { writeNameStr = value; }
        }
    
        public String BlackNameStr
        {
            get { return blackNameStr; }
            set { blackNameStr = value; }
        }



    }
}