using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using LotterySystem.Models;
using NHibernate;
using NHibernate.Criterion;
using LotterySystem.Util;

namespace LotterySystem.Dao
{
    public class RoomDaoImpl :RoomDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



        public Room getRoomByGameAndRoom(string gameName, string roomName)
        {
            Room room = new Room();
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                ICriteria criteria = session.CreateCriteria<Room>();

                criteria.Add(Restrictions.Eq("GameName", gameName));
                criteria.Add(Restrictions.Eq("RoomName", roomName));

                room = (Room)criteria.UniqueResult();

                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("search user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return room;
        }


        public List<Room> getRoomListByGameAndHoster(string gameName, String hoster)
        {
            List<Room> roomList = new List<Room>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();


                ICriteria criteria = session.CreateCriteria<Room>();
                criteria.Add(Restrictions.Eq("GameName", gameName));
                criteria.Add(Restrictions.Eq("RoomHost", hoster));
                var queryList = criteria.List<Room>();
                foreach (var result in queryList)
                {
                    roomList.Add(result);
                }


                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return roomList;
        }
       public  List<Room> getRoomByGame(string gameName)
        {
            List<Room> roomList = new List<Room>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();


                ICriteria criteria = session.CreateCriteria<Room>();
                criteria.Add(Restrictions.Eq("GameName", gameName));
        
                var queryList = criteria.List<Room>();
                foreach (var result in queryList)
                {
                    roomList.Add(result);
                }


                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return roomList;
        }

        public List<Room> getRoomByGameNameAndStatus(string gameName,string status)
        {
            List<Room> roomList = new List<Room>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();


                ICriteria criteria = session.CreateCriteria<Room>();
                criteria.Add(Restrictions.Eq("GameName", gameName));
                criteria.Add(Restrictions.Eq("Status", status));
                var queryList = criteria.List<Room>();
                foreach (var result in queryList)
                {
                    roomList.Add(result);
                }


                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return roomList;
        }

        public List<Room> getAll()
        {
           List<Room> roomList = new List<Room>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var queryList = session.CreateCriteria<Room>().List<Room>();
 
                foreach (var result in queryList)
                {
                    roomList.Add(result);
                }

 
                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return roomList;
        }
       
        public void createRoom(Room room)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(room);

                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
        }
        public void deleteRoomByRoomName(String roomName)
        {
        }
        public void updateRoom(Room room)
        {
        }
    }
}