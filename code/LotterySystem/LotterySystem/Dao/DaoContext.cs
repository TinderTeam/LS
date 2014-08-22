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
        private AccountDao accountDao;
        private RoomDao roomDao;
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

        public RoomDao getRoomDao()
        {

            if (roomDao == null)
            {
                roomDao = new RoomDaoImpl();
            }
            return roomDao;
        }

        public AccountDao getAccountDao()
        {

            if (accountDao == null)
            {
                accountDao = new AccountDaoImpl();
            }
            return accountDao;
        }
    }
}