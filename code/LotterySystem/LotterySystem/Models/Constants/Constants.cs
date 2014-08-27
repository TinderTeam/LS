using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserConstants
    {
        public const string IN_THE_HALL = "游戏大厅";
        public const string REGIST_NOT_OPEN = "系统目前未开放注册";
        public const string USERNAME_EXIST = "该用户名已被注册";
        public const string STATUS_ACTIVE = "激活";
        public const string STATUS_FREEZE = "冻结";
        public const string STATUS_WAIT = "待审";
        public const string PASSWORD_ERR = "密码错误";
    }
    public class RoomConstatns
    {
        public const string PAGE_CREATE = "create";
        public const string PAGE_EDIT = "edit";
        public const string STATUS_OPEN = "开放";
        public const string STATUS_CLOSE = "关闭";
        public const string STATUS_FREEZE= "冻结";
        public const string ERR_ALLROOM_LIMIT = "当前游戏房间数达到上限，无法创建房间";
        public const string ERR_USERROOM_LIMIT = "该用户在当前游戏中房间数达到上限，无法创建房间";
        public const string NULL = "无";
        public const string CREATE_ROOM_SUCCESS = "创建房间成功";
    }
    public class SysConstants
    {
        public const string SUCCESS = "success";

        public const char OS_BROWSER_SPLIT = ',';

        public static string[] OS_LIST = new string[]{"All","Linux","xp/win7","IOS"};
        public static string[] BROWSER_LIST = new string[] { "All", "Google", "IEs" };

        public const string REG_TYPE_0 = "方式0";
        public const string REG_TYPE_1 = "方式1";
        public const string REG_TYPE_2 = "方式2";
      
    }
}