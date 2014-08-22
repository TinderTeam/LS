using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Po;
namespace LotterySystem.Service.Login
{
    public class LoginService
    {
        UserDao userDao = DaoContext.getInstance().getUserDao();
        AccountDao accountDao = DaoContext.getInstance().getAccountDao();
        /// <summary>
        /// 系统登陆
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string userID ,string password){
            SystemUser user= userDao.getSystemUserByID(userID);
            if (user.Password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取登陆用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserModel getLoginUser(string userID)
        {
            UserModel userModel = new UserModel();
            SystemUser user = userDao.getSystemUserByID(userID);
            userModel.Permission = user.Permission;
            userModel.UserID = user.UserID;
            userModel.UserName = user.UserName;
            userModel.Status = user.Status;
            userModel.UserInfor = new UserInforModel();
            userModel.UserInfor.Points = accountDao.getAccountByUserID(userID);
            userModel.UserInfor.Position = UserConstants.IN_THE_HALL;
            return userModel;
        }

       
    }
}