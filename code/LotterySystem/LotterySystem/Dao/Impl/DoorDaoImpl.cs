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
       public  Door getDoorByRoomID(String roomID)
        {
            return null;
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
       public void deleteDoorByRoomID(String roomID)
        {
            
        }
       public void updateDoor(Door door)
        {
          
        }
    }
}