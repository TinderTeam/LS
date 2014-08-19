using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameProject.model.Constants;
namespace GameProject.model
{
    public class GameTabel
    {
        private static GameTabel gameTabel;

        private List<GameUser> gameList;

        public List<GameUser> GameList
        {
            get { return gameList; }
            set { gameList = value; }
        }

        GameTabel()
        {
            gameList = new List<GameUser>();
        }

        public static GameTabel getInstance()
        {
            if (gameTabel != null)
            {
                return gameTabel;
            }
            else
            {
                gameTabel = new GameTabel();
                return gameTabel;
            }
        }

        public List<GameUser>  getList()
        {
            return GameList;
        }
        /// <summary>
        /// 增加玩家
        /// </summary>
        /// <param name="name"></param>
        public GameUser addPlayer(string name)
        {
            if (!exist(name))
            {
                GameUser gameUser = new GameUser();
                gameUser.UserID = GameList.Count;
                gameUser.UserName = name;
                gameUser.UserStatus = GameTabelConstants.READY;
                GameList.Add(gameUser);
                return gameUser;
            }
            else
            {
                return null;
            }
            
        }

        public bool exist(string name)
        {
            for (int i = 0; i < GameList.Count; i++)
            {
                if (GameList[i].UserName.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }



}