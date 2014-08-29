using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using NHibernate;
using NHibernate.Criterion;

namespace LotterySystem.Dao
{
    public class DoorDaoImpl : DoorDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



        public Door getDoorByGameRoomUserType(string game, string room, string user, string type)
        {
            Door door = new Door();
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                ICriteria criteria = session.CreateCriteria<Door>();


                criteria.Add(Restrictions.Eq("UserName", user));
                criteria.Add(Restrictions.Eq("RoomName", room));
                criteria.Add(Restrictions.Eq("GameName", game));
                criteria.Add(Restrictions.Eq("EntranceType", type));

                door = (Door)criteria.UniqueResult();

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
            return door;
        }

        public List<Door> getAll()
        {
            List<Door> doorList = new List<Door>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var queryList = session.CreateCriteria<Door>().List<Door>();

                foreach (var result in queryList)
                {
                    doorList.Add(result);
                }
 
                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("get doors error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return doorList;
        }

       public void creatDoor(List<Door> list)
       {
           foreach (Door door in list)
           {
               creatDoor(door);
           }
       }
       public void creatDoor(Door door)
        {

            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(door);

                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create door error", ex);
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

       public void deleteGameAndRoom(string game, string room)
       {
           ISession session = null;
           try
           {
               session = SessionManager.getInstance().GetSession();
               ITransaction tx = session.BeginTransaction();
               var sql = "Delete from door Where  GAME_NAME=? and ROOM_NAME = ?";
               ISQLQuery query = session.CreateSQLQuery(sql);
               query.SetAnsiString(0, game);
               query.SetAnsiString(1, room);
               query.ExecuteUpdate();
               tx.Commit();
           }
           catch (System.Exception ex)
           {

               log.Error("delete room error", ex);
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

       public List<Door> getDoorByGameAndRoomAndType(string game, string room, string type)
       {
           List<Door> lst = new List<Door>();
           ISession session = null;
           try
           {


               session = SessionManager.getInstance().GetSession();
               ITransaction tx = session.BeginTransaction();


               ICriteria criteria = session.CreateCriteria<Door>();
               criteria.Add(Restrictions.Eq("RoomName", room));
               criteria.Add(Restrictions.Eq("GameName", game));
               criteria.Add(Restrictions.Eq("EntranceType", type));
               var queryList = criteria.List<Door>();
               foreach (var result in queryList)
               {
                   lst.Add(result);
               }

               tx.Commit();

           }
           catch (System.Exception ex)
           {

               log.Error("search door error", ex);
               throw ex;
           }
           finally
           {
               if (null != session)
               {
                   session.Close();
               }
           }
           return lst;
       }

       public void deleteDoorByRoomID(String roomID)
        {
            
        }
       public void updateDoor(Door door)
        {
          
        }
    }
}