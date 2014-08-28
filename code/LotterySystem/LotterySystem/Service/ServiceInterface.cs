using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
using LotterySystem.Po;
namespace LotterySystem.Service
{
    public interface PlatService
    {
        List<RoomModel>  getOpenRoomListByGameName(string gameID);
        List<GameModel>  getGameList();
        List<TableModel> getAllTableByGameAndRoom(string room, string game);
        DoorListModel getDoorByGameAndRoom(string game,string room);
        RoomModel getRoomByGameAndName(string gameName,string roomName);
        GameModel getGameByName(string gameName);

        String createRoom(String gameName, UserModel user,RoomForm model);
        String editRoomInfo(RoomForm model);
        void deleteRoom(string gameName, string roomName);

      
    }

    public interface ConvertService
    {
        RoomModel toRoomModel(Room room);
        RoomModel toRoomModel(RoomForm form);
        Room toRoom(RoomForm form);
        GameModel toGameModel(LotterySystem.Po.Game game);

        List<Door> toDoor(RoomForm model);

    }

    public interface GameManageService
    {
        void modifyGame(GameModel game);
    }

    public interface EntranceServcie
    {
        bool enterRoomCheck(UserModel user, RoomModel room);
    }

    public interface LoginService
    { 
        void Login(string userName ,string password);
        string register(UserRigistForm user);
        UserModel getLoginUser(string userName);
        bool LoginCheck();
    }

    public interface LogService
    {
        List<LoginLog> getLoginLogList();
        void recordLoginLog(String userName,String result,String os, String browser);

        List<ScoreLog> getScoreLogList();
        void recordScoreLog(ScoreLog log);

    }


    public interface UserService
    {
        bool CreateRoomCheck(UserModel user);
        List<UserModel> getUserList(String userName);
        UserModel getUserByName(String userName);
        string modifyLoginPassword(UserModel user, PasswordForm form);

        string modifyPayPassword(UserModel user, PasswordForm form);
        string modifyUser(UserForm form);
        string createNewUser(UserForm form);
        string approve(string userName);

        List<UserModel> getApproveListByUser( UserModel user);
    }

    public interface SysInfoService
    {
        SystemInfoModel loadSysInfo();
        void saveSysInfo(SystemInfoModel sysInfo);
    }

    public interface ScoreManageService
    {
        List<ScoreLog> getApprovalScoreList(String userName);
        List<ScoreLog> getRepayScoreList(String userName);
        void ApproveScore(ApproveScoreModel model, String userName);
        void handleLendScore(int logID, bool isAgree);
        void handleRepayScore(int logID);
    }
}
