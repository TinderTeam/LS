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
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
        public bool Login(string userName, string password)
        {
            LotterySystem.Po.User user = userDao.getSystemUserByName(userName);
            if (null == user)
            {
                log.Error("login failed, the user is not exist. user name is " + userName);
                return false;
            }
            if (!user.Password.Equals(password))
            {
                log.Error("login failed, the password is not right. user name is " + userName);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获取登陆用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserModel getLoginUser(string userName)
        {
            UserModel userModel = new UserModel();
            LotterySystem.Po.User user = userDao.getSystemUserByName(userName);
            userModel.Permission = user.Permission;
           
            userModel.UserName = user.UserName;
            userModel.Status = user.Status;
            userModel.UserInfor = new UserInforModel();
            userModel.UserInfor.Points = user.Account;
            userModel.UserInfor.Position = UserConstants.IN_THE_HALL;
            return userModel;
        }


    }
}