using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Models;
using LotterySystem.Util;
namespace LotterySystem.Service
{

    public class ConventService
    {
        public static RoomModel toRoomModel(Room room)
        {
            RoomModel roomModel= new RoomModel();
            roomModel.AccessAcountLimit=room.AccessAcountLimit;
            roomModel.Amplification =room.Amplification;
            roomModel.BankerLimit = room.BankerLimit;
            roomModel.BankerPointLimited=room.BasicPoint;
            roomModel.BasicPoint=room.BasicPoint;
            roomModel.GameName=room.GameName;
            roomModel.RoomHost=room.RoomHost;
            roomModel.RoomName=room.RoomName;
            roomModel.RoomPassword=room.RoomPassword;
            roomModel.Status = room.Status;
            return roomModel;
        }

        public static GameModel toGameModel(LotterySystem.Po.Game game)
        {
            if (game != null)
            {
                GameModel gameModel = new GameModel();
                gameModel.AllRoomLimit = game.PlayerSelectNumTimeLimit;
                gameModel.BankerSelectNumTimeLimit = game.BankerSelectNumTimeLimit;
                gameModel.Browser = game.Browser;
                gameModel.GameName = game.GameName;
                gameModel.GameStatus = game.GameStatus;
                gameModel.OnePersonRoomLimit = game.OnePersonRoomLimit;
                gameModel.OneRoomTableLimit = game.OneRoomTableLimit;
                gameModel.OneTablePersonLimit = game.OneTablePersonLimit;
                gameModel.Os = game.Os;
                gameModel.setBrowserList();
                gameModel.setOSList();
                gameModel.PlayerSelectNumTimeLimit = game.PlayerSelectNumTimeLimit;
                gameModel.TaxRate = game.TaxRate;
                return gameModel;
            }
            else
            {
                return null;
            }
         
        }

        public static RoomModel toRoomModel(RoomForm form)
        {
            RoomModel room =  new RoomModel();
            return room;
        }

        public static Room toRoom(RoomForm form)
        {
            Room room = new Room();
            room.GameName = form.GameName;
            room.AccessAcountLimit = form.AccessAcountLimit;
            room.Amplification = form.Amplification;
            room.BankerLimit = form.BankerLimit;
            room.BasicPoint = form.BasicPoint;
            room.RoomName = form.RoomName;
            room.RoomPassword = form.RoomPassword;
            room.Status = form.Status;

            return room;
        }

        public static List<Door> toDoor(RoomForm form)
        {
            List<Door> doorList = new List<Door>();

            if (form.WriteNameStr != null && !form.WriteNameStr.Equals(""))
            {
                string[] writeNameArray = form.WriteNameStr.Split(',');
                for (int i = 0; i < writeNameArray.Length; i++)
                {
                    Door door = new Door();
                    door.GameName = form.GameName;
                    door.RoomName = form.RoomName;
                    door.UserName = writeNameArray[i];
                    doorList.Add(door);
                }
            }

            if (form.BlackNameStr != null && !form.BlackNameStr.Equals(""))
            {
                string[] blackNameArray = form.BlackNameStr.Split(',');
                for (int i = 0; i < blackNameArray.Length; i++)
                {
                    Door door = new Door();
                    door.GameName = form.GameName;
                    door.RoomName = form.RoomName;
                    door.UserName = blackNameArray[i];
                    doorList.Add(door);
                }
            }
            return doorList;
        }
        public static UserModel toUserModel(User user)
        {
            UserModel userModel = new UserModel();
            userModel.UserID = user.UserID;
            userModel.UserName = user.UserName;
            userModel.Permission = user.Permission;
            userModel.Status = user.Status;
            userModel.RecommendUserName = user.RecommendUserName;
            return userModel;

        }
        public static User toUser(UserRigistForm model)
        {
            User user = new User();
            user.UserName = model.UserName;
            user.Password = model.Password;
            user.PayPassword = model.PayPassword;
            user.RecommendUserName = model.RecommendUserName;
            return user;

        }

        public static User toUser(UserForm model)
        {
            User user = new User();
            user.Password = model.Password;
            user.PayPassword = model.PayPassword;
            user.RecommendUserName = model.RecommendUserName;
            user.Status = model.Status;
            return user;

        }
        public static List<UserModel> toUserModelList(List<User> userList)
        {
            List<UserModel> userModelList = new List<UserModel>();
            for (int i = 0; i < userList.Count; i++)
            {
                userModelList.Add(toUserModel(userList[i]));
            }
            return userModelList;
        }
        public static SystemInfoModel toSysInfoModel(Sys sysInfo)
        {
            SystemInfoModel systemInfoModel = new SystemInfoModel();
            systemInfoModel.MaxPlayer = sysInfo.MaxPlayer;
            systemInfoModel.RegistType = sysInfo.RegistType;

            return systemInfoModel;
        }
    }
}