using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Po;

namespace LotterySystem.Service.Login
{
    public class LoginServiceImpl : LoginService
    {
        UserDao userDao = DaoContext.getInstance().getUserDao();
        AccountDao accountDao = DaoContext.getInstance().getAccountDao();
        SysDao sysDao = DaoContext.getInstance().getSysDao();



        /// <summary>
        /// 
        /// 检查系统状态
        /// </summary>
        /// <returns></returns>
        public bool LoginCheck()
        {
            long getMaxPlayer = sysDao.getMaxPlayer();
            //检查系统状态
            if (SysCatch.OnlinePlayerNum + 1 <= getMaxPlayer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 系统登陆
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string userID, string password)
        {
            LotterySystem.Po.User user = userDao.getSystemUserByID(userID);
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
            LotterySystem.Po.User user = userDao.getSystemUserByID(userID);
            userModel.Permission = user.Permission;
            //userModel.UserID = user.UserID;
            userModel.UserName = user.UserName;
            userModel.Status = user.Status;
            userModel.UserInfor = new UserInforModel();
            userModel.UserInfor.Points = accountDao.getAccountByUserID(userID);
            userModel.UserInfor.Position = UserConstants.IN_THE_HALL;
            return userModel;
        }


    }
}