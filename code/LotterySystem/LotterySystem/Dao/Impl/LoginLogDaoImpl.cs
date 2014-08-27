using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using NHibernate;
using NHibernate.Criterion;

namespace LotterySystem.Dao.Impl
{
    public class LoginLogDaoImpl : LoginLogDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        public List<LoginLog> getAll()
        {

            List<LoginLog> logList = new List<LoginLog>();
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                var queryList = session.CreateCriteria<LoginLog>().List<LoginLog>();

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


        public LoginLog getLoginLogByUserName(String userName)
        {
            return null;
        }
        public void creatLoginLog(LoginLog loginLog)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(loginLog);

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


        public void deleteLoginLogByUserName(String userName)
        {
        }
        public void updateLoginLog(LoginLog loginLog)
        {
        }
    }
}