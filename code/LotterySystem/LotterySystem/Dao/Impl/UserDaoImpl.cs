using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using NHibernate;
using NHibernate.Cfg;
using log4net;
using NHibernate.Criterion;

namespace LotterySystem.Dao
{
    public class UserDaoImpl:UserDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void createUser(User user)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(user);

                tx.Commit();
               

            }
            catch (System.Exception ex)
            {

                log.Error("create user error", ex);
                throw ex;
            }
            finally
            {
                if(null != session)
                {
                     session.Close();
                }
            }
        }
        public void deleteUserByUserName(String userName)
        {

            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();
                var sql = "Delete from t_user Where USER_NAME = ?";
                ISQLQuery query = session.CreateSQLQuery(sql);
                query.SetAnsiString(0, userName);
                query.ExecuteUpdate();
                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("delete user error", ex);
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
        public void updateUser(User user)
        {
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.SaveOrUpdate(user);

                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("update user error", ex);
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
           public User getSystemUserByName(string userName)
           {
               User sysUser = new User();
               ISession session = null;
               try
               {
                   session = SessionManager.getInstance().GetSession();
                   ITransaction tx = session.BeginTransaction();

                   ICriteria criteria = session.CreateCriteria<User>();

                  
                   criteria.Add(Restrictions.Eq("UserName", userName));

                   sysUser =(User) criteria.UniqueResult();
                   
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
               return sysUser;
           }

          	

	

        

    }
}