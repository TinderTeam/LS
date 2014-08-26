using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    [Serializable]
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

        public virtual String GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }

        public virtual int BankerLimit
        {
            get { return bankerLimit; }
            set { bankerLimit = value; }
        }


        public virtual String RoomName
        {
            get { return roomName; }
            set { roomName = value; }

        }

        public virtual String RoomPassword
        {
            get { return roomPassword; }
            set { roomPassword = value; }
        }

        public virtual String RoomHost
        {
            get { return roomHost; }
            set { roomHost = value; }
        }

        public virtual String Status
        {
            get { return status; }
            set { status = value; }
        }

        public virtual int AccessAcountLimit
        {
            get { return accessAcountLimit; }
            set { accessAcountLimit = value; }
        }

        public virtual int BasicPoint
        {
            get { return basicPoint; }
            set { basicPoint = value; }
        }

        public virtual int Amplification
        {
            get { return amplification; }
            set { amplification = value; }
        }
        public override bool Equals(object obj)
        {
              if (this == obj)
               return true;
              if (obj == null)
               return false;
              if (!(obj is Room))
               return false;
              Room other = (Room) obj;
              if (roomName == null) 
              {
               if (other.roomName != null)
                return false;
              } 
              else if (!(roomName==other.roomName))
               return false;
              if (gameName == null) 
              {
               if (other.gameName != null)
                return false;
              } 
              else if (!(gameName==(other.gameName)))
               return false;
              return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}