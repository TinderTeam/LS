using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Po
{
    public class UserPosition
    {
        private string userName;
        private string gameName;
        private string roomName;
        private string gamblingPartyId;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }     
        public string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }    
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }      
        public string GamblingPartyId
        {
            get { return gamblingPartyId; }
            set { gamblingPartyId = value; }
        }
    }
}