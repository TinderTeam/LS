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

        
    }
}