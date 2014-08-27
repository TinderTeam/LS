using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
using LotterySystem.Test.Stub;
using NHibernate;
using NHibernate.Criterion;
using LotterySystem.Util;

namespace LotterySystem.Dao.Impl
{
    public class GamblingPartyDaoImpl:GamblingPartyDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public  List<GamblingParty> getAll()
        {

            List<GamblingParty> gamblingList = new List<GamblingParty>();
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var queryList = session.CreateCriteria<GamblingParty>().List<GamblingParty>();
                foreach (var result in queryList)
                {
                    gamblingList.Add(result);
                }
                tx.Commit();
            }

            catch (System.Exception ex)
            {

                log.Error("create gamblingList error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return gamblingList;
            

        }
        public GamblingParty getGamblingPartyByGamblingPartyID(String gamblingPartyID)
        {
            return null;
        }
        public void creatGamblingParty(GamblingParty gamblingParty)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(gamblingParty);

                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create gamblingParty error", ex);
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
        public void deleteGamblingPartyByGamblingPartyID(String gamblingPartyID)
        {
        }
        public void updateGamblingParty(GamblingParty gamblingParty)
        {
        }

        public  List<GamblingParty> getGamblingPartyByGameAndRoom(String game, String room)
        {
            List<GamblingParty> gamblingList = new List<GamblingParty>();
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();


                ICriteria criteria = session.CreateCriteria<GamblingParty>();
                criteria.Add(Restrictions.Eq("GameName", game));
                criteria.Add(Restrictions.Eq("RoomName", room));

                var queryList = session.CreateCriteria<GamblingParty>().List<GamblingParty>();
                foreach (var result in queryList)
                {
                    gamblingList.Add(result);
                }
                tx.Commit();
            }

            catch (System.Exception ex)
            {

                log.Error("create gamblingList error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return gamblingList;
        }
     }
}