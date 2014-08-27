using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Test.Stub;
using LotterySystem.Po;
using NHibernate;
using NHibernate.Criterion;
using LotterySystem.Util;

namespace LotterySystem.Dao
{
    public class SysDaoImpl : SysDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);       
        public Sys getall()
        {
            Sys sys = new Sys();
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();
                ICriteria criteria = session.CreateCriteria<Sys>();
                sys = (Sys)criteria.UniqueResult();
                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("getall sysinfo error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return sys;
        }
        public void updateSys(Sys sysInfo)
        {
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var sql = "Delete from sys";
                ISQLQuery query = session.CreateSQLQuery(sql);
                
                query.ExecuteUpdate();

                session.Save(sysInfo);

                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("update sysinfo error", ex);
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

    }
}