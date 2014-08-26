using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserConstants
    {
        public static string IN_THE_HALL = "游戏大厅";
    }
    public class RoomConstatns
    {
        public static string STATUS_OPEN = "开放";
        public static string STATUS_CLOSE = "关闭";
        public static string STATUS_FREEZE= "冻结";
        public static string ERR_ALLROOM_LIMIT = "当前游戏房间数达到上限，无法创建房间";
        public static string ERR_USERROOM_LIMIT = "该用户在当前游戏中房间数达到上限，无法创建房间";
        public static string NULL = "无";
    }
    public class SysConstants
    {
        public static string SUCCESS = "success";
      
    }
}