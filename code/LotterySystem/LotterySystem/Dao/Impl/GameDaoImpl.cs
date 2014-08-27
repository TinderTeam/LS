using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
using NHibernate;
using NHibernate.Criterion;
using LotterySystem.Util;

namespace LotterySystem.Dao
{
    public class GameDaoImpl:GameDao
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Game> getAll()
        {
            List<Game> gameList = new List<Game>();
            ISession session = null;
            try 
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();
                
                var queryList = session.CreateCriteria<Game>().List<Game>();
                foreach (var result in queryList)
                {
                    gameList.Add(result);
                }
                tx.Commit();
            }
            
          catch (System.Exception ex)
            {

                log.Error("create game error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return gameList;
            //return DBStub.getDBStub().getGameList();
        }

        public Game getGameByName(String gameName)
        {
            Game game = new Game();
            ISession session = null;
            try 
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                ICriteria criteria = session.CreateCriteria<Game>();


                criteria.Add(Restrictions.Eq("GameName", gameName));

                game = (Game)criteria.UniqueResult();

                tx.Commit();


            }

            catch (System.Exception ex)
            {

                log.Error("search game error", ex);
                throw ex;
            }
            finally
            {
                if (null != session)
                {
                    session.Close();
                }
            }
            return game;
            /* for (int i = 0; i < DBStub.getDBStub().getGameList().Count; i++)
             { 
                 if(DBStub.getDBStub().getGameList()[i].GameName.Equals(gameName))
                 {
                     return DBStub.getDBStub().getGameList()[i];
                 }
             }
             return null;
             */
        }
        public void creatGame(Game game)
        {
            ISession session = null;
            try
            {

                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.Save(game);

                tx.Commit();


            }
            catch (System.Exception ex)
            {

                log.Error("create game error", ex);
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
        public void deleteGameByName(String gameName)
        {
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();
                var sql = "Delete from game Where GAME_NAME = ?";
                ISQLQuery query = session.CreateSQLQuery(sql);
                query.SetAnsiString(0, gameName);
                query.ExecuteUpdate();
                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("delete game error", ex);
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
        public void updateGame(Game game)
        {
            ISession session = null;
            try
            {
                session = SessionManager.getInstance().GetSession();
                ITransaction tx = session.BeginTransaction();

                session.SaveOrUpdate(game);

                tx.Commit();

            }
            catch (System.Exception ex)
            {

                log.Error("update game error", ex);
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