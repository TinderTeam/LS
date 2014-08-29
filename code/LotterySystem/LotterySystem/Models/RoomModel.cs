using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Util;

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
        private String whiteNameStr;
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

        public String WhiteNameStr
        {
            get { return whiteNameStr; }
            set { whiteNameStr = value; }
        }
    
        public String BlackNameStr
        {
            get { return blackNameStr; }
            set { blackNameStr = value; }
        }



    }

    public class DoorListModel
    {
        List<DoorModel> whiteList;
        List<DoorModel> blackList;

        public List<DoorModel> WhiteList
        {
            get { return whiteList; }
            set { whiteList = value; }
        }

        public List<DoorModel> BlackList
        {
            get { return blackList; }
            set { blackList = value; }
        }

        public string getWhiteListStr(){

            string str = "";
            if ((null != whiteList) && (0 != whiteList.Count))
            {
                str = whiteList[0].UserName;
                for (int i = 1; i < whiteList.Count; i++)
                {
                    str = str + "," + whiteList[i].UserName;
                }
            }

           return str;
        }
        public string getBlackListStr()
        {
            string str = "";
            if ((null != blackList) && (0 != blackList.Count))
            {
                str = blackList[0].UserName;
                for (int i = 1; i < blackList.Count; i++)
                {
                    str = str + "," + blackList[i].UserName;
                }
            }
            return str;
        }

        
    }
    public class DoorModel
    {
        private String roomName;
        private String gameName;
        private String userName;
        private String entranceType;
        public virtual String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public virtual String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public virtual String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public virtual String EntranceType
        {
            get { return entranceType; }
            set { entranceType = value; }
        }
    }

    public class RoomPasswordForm
    {
        private String password;
        private String roomName;

        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}