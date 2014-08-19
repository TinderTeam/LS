using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameProject.model
{
    public class GameUser
    {
        private int userID;
        private string userName;
        private string userStatus;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

       public string UserName
       {
           get { return userName; }
           set { userName = value; }
       }
     
       public string UserStatus
       {
           get { return userStatus; }
           set { userStatus = value; }
       }

    }
}