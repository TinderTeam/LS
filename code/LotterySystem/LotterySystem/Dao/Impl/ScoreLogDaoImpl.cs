using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using NHibernate;
using NHibernate.Criterion;

namespace LotterySystem.Dao.Impl
{
    public class ScoreLogDaoImpl : ScoreLogDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        public List<ScoreLog> getAll()
        {

            List<ScoreLog> logList = new List<ScoreLog>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var queryList = session.CreateCriteria<ScoreLog>().List<ScoreLog>();

                foreach (var result in queryList)
                {
                    logList.Add(result);
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
            return logList;
        }


       
        public void creatScoreLog(ScoreLog ScoreLog)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(ScoreLog);

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

 
    }
}