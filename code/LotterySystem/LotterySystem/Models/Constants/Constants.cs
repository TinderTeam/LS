using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserConstants
    {
        public static string IN_THE_HALL = "游戏大厅";
        public static string REGIST_NOT_OPEN = "系统目前未开放注册";
        public static string USERNAME_EXIST = "该用户名已被注册";
        public static string STATUS_ACTIVE = "激活";
        public static string STATUS_FREEZE = "冻结";
        public static string STATUS_WAIT = "待审";
        public static string PASSWORD_ERR = "密码错误";
    }
    public class RoomConstatns
    {
        public static string PAGE_CREATE = "create";
        public static string PAGE_EDIT = "edit";
        public static string STATUS_OPEN = "开放";
        public static string STATUS_CLOSE = "关闭";
        public static string STATUS_FREEZE= "冻结";
        public static string ERR_ALLROOM_LIMIT = "当前游戏房间数达到上限，无法创建房间";
        public static string ERR_USERROOM_LIMIT = "该用户在当前游戏中房间数达到上限，无法创建房间";
        public static string NULL = "无";
        public static string CREATE_ROOM_SUCCESS = "创建房间成功";
    }
    public class SysConstants
    {
        public static string SUCCESS = "success";
      
    }
}