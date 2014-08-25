using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class Door
    {
        private String roomName;
        private String gameName;
        private String userName;
        private String entranceType;


        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public String EntranceType
        {
            get { return entranceType; }
            set { entranceType = value; }
        }
    }
}