using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class RoomModel
    {
        private int roomNum;
        private string amplification;
        private string roomStatus;
        private string playerLimit;
        private int accessAcountLimit;
        private int basicPoint;
        private string roomID;
        private string roomName;
        private string roomPassword;
        private string hostName;

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }
       

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        
        public string RoomPassword
        {
            get { return roomPassword; }
            set { roomPassword = value; }
        }
        
        public string HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }
       
        public string RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }
       
        public string PlayerLimit
        {
            get { return playerLimit; }
            set { playerLimit = value; }
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
       
        public string Amplification
        {
            get { return amplification; }
            set { amplification = value; }
        }



    }

    public class RoomListModel
    {
        private List<RoomModel> roomListModel;

        public List<RoomModel> RoomList
        {
            get { return roomListModel; }
            set { roomListModel = value; }
        }

        /// <summary>
        /// 创建Room
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public RoomModel createNewRoom(RoomModel room)
        {
            room.RoomNum=this.RoomList.Count;
            return room;
        }

    }
}