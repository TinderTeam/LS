
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

        private static Sys sys;
        private static List<Game> gameList;
        private static List<Account> accountList;
        private static List<Room> roomList;
        private static List<GamblingParty> gamblingPartyList;

        public static DBStub getDBStub()
        {
            if(dbStub==null){
                dbStub=new DBStub();
            }
            return dbStub;
        }
        public  List<GamblingParty> getGamblingPartyList()
        {
            if (gamblingPartyList == null)
            {
                gamblingPartyList = new List<GamblingParty>();
                for (int i = 0; i <getGameList().Count; i++)
                {
                    for (int j = 0; j < roomList.Count; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            GamblingParty gamblingParty = new GamblingParty();
                            gamblingParty.GamblingPartyID = new Random().Next();
                            gamblingParty.GameName = gameList[i].GameName;
                            gamblingParty.RoomName = roomList[j].RoomName;
                            gamblingParty.BankerStartTime = DateTime.Now;
                            gamblingParty.BankerEndTime = new DateTime();
                            gamblingParty.TableNum = k;
                            gamblingParty.Banker = "测试用户"+k;
                            gamblingPartyList.Add(gamblingParty);
                        }
                    }
                }
            }

            return gamblingPartyList;
        }

        public List<Room> getRoomList()
        {
            if (roomList == null)
            {
               roomList = new List<Room>();
               Room room = new Room();
               room.Status = "开放";
               room.RoomName = "测试房间";
               room.RoomHost = "admin";
               room.GameName = "猜数字";
               room.BasicPoint = 10;
               room.BankerLimit = 10;
               room.Amplification=10;
               roomList.Add(room);
               Room room2 = new Room();
               room2.Status = "开放";
               room2.RoomName = "测试房间2";
               room2.RoomHost = "test";
               room2.GameName = "猜数字";
               room2.BasicPoint = 10;
               room2.BankerLimit = 10;
               room2.Amplification = 10;
               roomList.Add(room2);
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
                
                sys.MaxPlayer = 10;
               
                sys.RegistType = "方式2";
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