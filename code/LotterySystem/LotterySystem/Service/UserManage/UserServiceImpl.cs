using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
using LotterySystem.Dao;
using LotterySystem.Po;

namespace LotterySystem.Service.UserManage
{
    public class UserServiceImpl :UserService
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        UserDao userDao = DaoContext.getInstance().getUserDao();







        public List<UserModel> getApproveListByUser(UserModel user)
        {
            List<UserModel> list ;
            List<User> userList= userDao.getApprovalUserListByRecomName(user.UserName);
            list= ConventService.toUserModelList(userList);
            return list;
        }



        public bool CreateRoomCheck(UserModel user)
        {
            //To be Implement
            return true;
        }
        public List<UserModel> getUserList(String userName)
        {
            List<User> userList = userDao.getSystemUserByFilter(userName);

            return ConventService.toUserModelList(userList);
        }
        public UserModel getUserByName(String userName)
        {
           User user =  userDao.getSystemUserByName(userName);
           if (null == user)
           {
               log.Error("can not get the user by " + userName);
               return null;
           }
           return ConventService.toUserModel(user);
        }

        public string modifyLoginPassword(UserModel model, PasswordForm form)
        {
            User user = userDao.getSystemUserByName(model.UserName);
            if (user.Password.Equals(form.Password))
            {
                user.Password = form.NewPassword;
                userDao.updateUser(user);
                return SysConstants.SUCCESS;
            }
            else
            {
                return UserConstants.PASSWORD_ERR;
            }
        }
        public string modifyPayPassword(UserModel model, PasswordForm form)
        {
            User user = userDao.getSystemUserByName(model.UserName);
            if (user.PayPassword.Equals(form.Password))
            {
                user.PayPassword = form.NewPassword;
                userDao.updateUser(user);
                return SysConstants.SUCCESS;
            }
            else
            {
                return UserConstants.PASSWORD_ERR;
            }
        }

        public string modifyUser(UserForm model)
        {
            User user = userDao.getSystemUserByName(model.UserName);
            user.Password = model.Password;
            user.PayPassword = model.PayPassword;
            user.RecommendUserName = model.RecommendUserName;
            user.Status = model.Status;
            
            userDao.updateUser(user);
            return SysConstants.SUCCESS;          
        }
        public string createNewUser(UserForm model)
        {
            User user = new User();
            user.UserName = model.UserName;
            user.Password = model.Password;
            user.PayPassword = model.PayPassword;
            user.RecommendUserName = model.RecommendUserName;
            user.Status = model.Status;
            userDao.createUser(user);

            ServiceContext.getInstance().getScoreManageService().openAccount(user.UserName);
            return SysConstants.SUCCESS;  
        }

        public string approve(string userName)
        {
            User user =userDao.getSystemUserByName(userName);
            user.Status = UserConstants.STATUS_ACTIVE;
            userDao.updateUser(user);

            return SysConstants.SUCCESS;
        }

        public void isUserExist(int userID,string userName)
        {
            User lendUser = userDao.getSystemUserByName(userName);
            if (null == lendUser)
            {
                log.Error("user name is not exist ");
                throw new SystemException(ErrorMsgConst.USER_NOT_EXITED);
            }
            if (lendUser.UserID != userID)
            {
                log.Error("user name is match user id ");
                throw new SystemException(ErrorMsgConst.USER_NOT_MATCH);
            }
        }
    }
}