using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
namespace LotterySystem.Test.Stub
{
    public static class UserStub
    {
        public static SystemUser getStubUser()
        {
            SystemUser user = new SystemUser();
            user.UserID = "test@163.com";
            user.UserName = "测试用户—基本";
            user.Password = "1234";
            user.PayPassword = "1234";
            user.Status = "OK";
            user.Permission = "all";
            return user;
        }

        public static List<SystemUser> getStubUserList()
        {
            List<SystemUser> list = new List<SystemUser>();
            for (int i = 0; i < 10; i++)
            {
                SystemUser user = new SystemUser();
                user.UserID = "test_"+i+"@163.com";
                user.UserName = "测试用户—"+i;
                user.Password = "1234";
                user.PayPassword = "1234";
                user.Status = "OK";
                user.Permission = "all";
               list.Add(user);
            }
            return list;
        }


    }


    public static class SysStub{
        public static List<GameInfoModel> getGameList()
        {
            List<GameInfoModel> list = new List<GameInfoModel>();
            GameInfoModel gameInfoModel = new GameInfoModel();
            gameInfoModel.GameID = 0;
            gameInfoModel.GameName = "竞猜游戏";
            GameInfoModel gameInfoModel2 = new GameInfoModel();
            gameInfoModel2.GameID = 1;
            gameInfoModel2.GameName = "德州扑克";
            list.Add(gameInfoModel);
            list.Add(gameInfoModel2);

            for (int i = 0; i < 10; i++)
            {
                GameInfoModel game = new GameInfoModel();
                game.GameID =i+2;
                game.GameName = "其他游戏_"+i;
                list.Add(game);
            }
            return list;
        }
    }
        

    public static class TabelStub
    {
       
        public static TabelModel getTabelModel(int i)
        {
            TabelModel tabel = new TabelModel();
            tabel.StartTime = DateTime.Now;
            tabel.EndTime = DateTime.Now;
            tabel.BankerID = "admin@123.com";
            tabel.BankerName = "admin";

            return tabel;
        }

        public static List<TabelModel> getStubTabelModelLsit()
        {
            List<TabelModel> list = new List<TabelModel>();
            for (int i = 0; i < 10; i++)
            {
                TabelModel tabel = getTabelModel(i);
                list.Add(tabel);
            }
            return list;
        }


    }
    public static class RoomStub

    {
        public static RoomModel getRoomModel(int i)
        {
            RoomModel room = new RoomModel();
            room.HostName = "测试房主_" + i;
            room.PlayerLimit = "<=" +new Random().Next();
            room.RoomID = ""+new Random().Next(); 
            room.RoomName = "测试房间" + i;
            room.RoomNum = i;
            room.RoomPassword = "1234";
            room.RoomStatus = "准备中";
            room.BasicPoint = 100;
            room.Amplification = "无";
            room.AccessAcountLimit=1000;
            room.TabelModelList = TabelStub.getStubTabelModelLsit();
            return room;
        }

        public static List<RoomModel> getRoomModelList()
        {
            List<RoomModel> list = new List<RoomModel>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(getRoomModel(i));
            }
            return list;
        }

        public static RoomListModel getRoomListModel()
        {
            RoomListModel roomListModel = new RoomListModel();
            roomListModel.RoomList = getRoomModelList();
            return roomListModel;
        }
    }
}