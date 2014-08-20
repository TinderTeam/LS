using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Dao
{
    public class DaoContext
    {
         static DaoContext daoContext;


        private UserDao userDao;


        public static DaoContext getInstance()
        {

            if (daoContext == null)
            {
                daoContext = new DaoContext();                
            }
            return daoContext;
        }

        public UserDao getUserDao()
        {

            if (userDao == null)
            {
                userDao = new UserDao();
            }
            return userDao;
        }
    }
}