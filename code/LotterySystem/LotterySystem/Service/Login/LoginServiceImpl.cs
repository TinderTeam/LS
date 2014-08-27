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
            Sys sysInfo = sysDao.getall();
            if(null == sysInfo)
            {
                return false;
            }

            long getMaxPlayer = sysInfo.MaxPlayer;
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
        public void Login(string userName, string password)
        {
            if (!LoginCheck())
            {
                log.Error("the login user number is max");

                throw new SystemException("服务器已经满员，请稍后再尝试");
            }


            LotterySystem.Po.User user = userDao.getSystemUserByName(userName);
            if (null == user)
            {
                log.Error("login failed, the user is not exist. user name is " + userName);
                throw new SystemException("用户名或密码错误");
            }
            
            if (null == user.Password || !user.Password.Equals(password))
            {
                log.Error("login failed, the password is not right. user name is " + userName);
                throw new SystemException("用户名或密码错误");
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

        public string register(UserRigistForm model)
        {
            int sysRigisterType =sysDao.getRegistType();
            User user = ConventService.toUser(model);

            switch(sysRigisterType){
                case 0:
                    return UserConstants.REGIST_NOT_OPEN;
                case 1:
                    user.Status = UserConstants.STATUS_WAIT;
                    break;
                case 2:
                    user.Status = UserConstants.STATUS_ACTIVE;
                    break;
                default:
                    break;
            }

            User userCheck = userDao.getSystemUserByName(model.UserName);
            if (userCheck != null)
            {
                return UserConstants.USERNAME_EXIST;
            }
            
            userDao.createUser(user);
            return SysConstants.SUCCESS;
        }

    }
}