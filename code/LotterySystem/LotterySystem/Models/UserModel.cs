using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace LotterySystem.Models
{
    public class UserModel
    {
        private int userID;
        private String userName;
        private String status;
        private String permission;
        private String recommendUserName;


        private UserInforModel userInfor;

        public UserInforModel UserInfor
        {
            get { return userInfor; }
            set { userInfor = value; }
        }


        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }
       

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        public String RecommendUserName
        {
            get { return recommendUserName; }
            set { recommendUserName = value; }
        }
       
    }
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class UserInforModel
    {
        private int points;
        private string position;


        public void setPositionByRoomInfo(string roomID, string roomName)
        {
            this.position = roomID + "_" + roomName;
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }


    }
    public class UserRigistForm
    {
        private String userName;
        private String password;
        private String payPassword;
        private String recommendUserName;

        public String RecommendUserName
        {
            get { return recommendUserName; }
            set { recommendUserName = value; }
        }

        public String PayPassword
        {
            get { return payPassword; }
            set { payPassword = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}