using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    [Serializable]
    public class Door
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
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (!(obj is Door))
                return false;
            Door other = (Door)obj;
            if (roomName == null)
            {
                if (other.roomName != null)
                    return false;
            }
            else if (!(roomName == other.roomName))
                return false;
            if (gameName == null)
            {
                if (other.gameName != null)
                    return false;
            }
            else if (!(gameName == (other.gameName)))
                return false;
            if (userName == null)
            {
                if (other.userName != null)
                    return false;
            }
            else if (!(userName == (other.userName)))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}