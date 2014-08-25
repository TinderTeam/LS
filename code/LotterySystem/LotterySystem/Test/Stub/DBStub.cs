
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
namespace LotterySystem.Test.Stub
{

  

    public  class DBStub
    {
        private static  DBStub dbStub;

        private Sys sys;
        private List<Game> gameList;
        private List<Account> accountList;
        private List<Room> roomList;

      
        public static DBStub getDBStub()
        {
            if(dbStub==null){
                dbStub=new DBStub();
            }
            return dbStub;
        }


        public List<Room> getRoomList()
        {
            if (roomList == null)
            {
               roomList = new List<Room>();
            }
            return roomList;
        }


        public List<Account> getAccountList()
        {
            if (accountList == null)
            {
                accountList = new List<Account>();
                Account account = new Account();
                account.UserName = "admin";
                account.AccountValue=100;
                accountList.Add(account);
            }
            return accountList;
        }

        public Sys getSys()
        {
            if (sys == null)
            {
                sys = new Sys();
                sys.Browser = "";
                sys.MaxPlayer = 10;
                sys.Os = "";
                sys.RegistType = 2;
            }
            return sys;
        }

        public Sys Sys
        {
            get { return sys; }
            set { sys = value; }
        }

        public List<Game> getGameList()
        {
            if (gameList == null)
            {
                gameList = new List<Game>();
                Game game = new Game();
                game.GameName="猜数字";
                game.TaxRate=0.1f;
                game.OneTablePersonLimit = 20;
                game.OneRoomTableLimit = 20;
                game.OnePersonRoomLimit = 5;
                game.GameStatus = "开放";
                game.AllRoomLimit = 60;
                game.BankerSelectNumTimeLimit = 30;
                game.PlayerSelectNumTimeLimit = 60;
                gameList.Add(game);
               
            }
            return gameList;
        }

        public List<Game> GameList
        {
            get { return gameList; }
            set { gameList = value; }
        }

    }

}