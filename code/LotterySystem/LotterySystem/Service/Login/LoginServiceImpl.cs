using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Po;
using LotterySystem.Util;

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
            Sys sysInfo = sysDao.getFirst();
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

            if (user.Status.Equals(UserConstants.STATUS_FREEZE))
            {
                throw new SystemException(ErrorMsgConst.USER_IS_FREEZE);
            }

            if (user.Status.Equals(UserConstants.STATUS_WAIT))
            {
                throw new SystemException(ErrorMsgConst.USER_IS_WAIT);
            }

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
            SysCatch.OnlinePlayerNum++;
            
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
            string sysRigisterType = sysDao.getFirst().RegistType;
            User user = ConventService.toUser(model);

            switch(sysRigisterType)
            {
                case SysConstants.REG_TYPE_0:
                    throw new SystemException(ErrorMsgConst.REGIST_NOT_OPEN);
                case SysConstants.REG_TYPE_1:
                    user.Status = UserConstants.STATUS_WAIT;
                    User remUser  = userDao.getSystemUserByName(model.RecommendUserName);

                    ServiceContext.getInstance().getUserService().isUserExist(model.RecommendUserID, model.RecommendUserName);
                    break;
                case SysConstants.REG_TYPE_2:
                    user.Status = UserConstants.STATUS_ACTIVE;
                    model.RecommendUserName = SysConstants.SYS_ADMIN_USER;
                    break;
                default:
                    break;
            }

            User userCheck = userDao.getSystemUserByName(model.UserName);
            if (userCheck != null)
            {
                log.Error("the name is existed. user name is " + model.UserName);
               throw new SystemException(ErrorMsgConst.USERNAME_EXIST);
            }
            
            userDao.createUser(user);

            ServiceContext.getInstance().getScoreManageService().openAccount(user.UserName);

            return SysConstants.SUCCESS;
        }

    }
}