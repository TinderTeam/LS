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
        private String permission;

        public String Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        private String userID;

        public String UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

       
    }
    public class LoginModel
    {
        [Required]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}