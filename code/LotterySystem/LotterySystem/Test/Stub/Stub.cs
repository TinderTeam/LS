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
        public static User getStubUser()
        {
            User user = new User();
            user.UserID =1;
            user.UserName = "admin";
            user.Password = "1234";
            user.PayPassword = "1234";
            user.Status = "OK";
            user.Permission = "all";
            return user;
        }

        public static List<User> getStubUserList()
        {
            List<User> list = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                User user = new User();
                user.UserID = i;
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

    }
        

    public static class TabelStub
    {
       
        public static TableModel getTabelModel(int i)
        {
            TableModel tabel = new TableModel();
            tabel.StartTime = DateTime.Now;
            tabel.EndTime = DateTime.Now;
            tabel.BankerID = "admin@123.com";
            tabel.BankerName = "admin";

            return tabel;
        }

        public static List<TableModel> getStubTabelModelLsit()
        {
            List<TableModel> list = new List<TableModel>();
            for (int i = 0; i < 10; i++)
            {
                TableModel tabel = getTabelModel(i);
                list.Add(tabel);
            }
            return list;
        }


    }
    public static class RoomStub

    {
       
     
    }
}