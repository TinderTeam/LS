using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Dao;
using LotterySystem.Dao.Impl;
namespace LotterySystem.Dao
{
    public class DaoContext
    {
         static DaoContext daoContext;
        private UserDao userDao;
        private AccountDao accountDao;
        private RoomDao roomDao;
        private SysDao sysDao;
        private GameDao gameDao;
        private DoorDao doorDao;
        private GamblingPartyDao gamblingPartyDao; 

        public static DaoContext getInstance()
        {

            if (daoContext == null)
            {
                daoContext = new DaoContext();                
            }
            return daoContext;
        }


        public GamblingPartyDao getGamblingPartyDao()
        {

            if (gamblingPartyDao == null)
            {
                gamblingPartyDao = new GamblingPartyDaoImpl();
            }
            return gamblingPartyDao;
        }

        public DoorDao getDoorDao()
        {

            if (doorDao == null)
            {
                doorDao = new DoorDaoImpl();
            }
            return doorDao;
        }


        public GameDao getGameDao()
        {

            if (gameDao == null)
            {
                gameDao = new GameDaoImpl();
            }
            return gameDao;
        }

        public UserDao getUserDao()
        {

            if (userDao == null)
            {
                userDao = new UserDaoImpl();
            }
            return userDao;
        }

        public SysDao getSysDao()
        {

            if (sysDao == null)
            {
                sysDao = new SysDaoImpl();
            }
            return sysDao;
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