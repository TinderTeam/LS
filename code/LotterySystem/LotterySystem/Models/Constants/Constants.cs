using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotterySystem.Models
{
    public class UserConstants
    {
        public const string IN_THE_HALL = "游戏大厅";

        public const string STATUS_ACTIVE = "激活";
        public const string STATUS_FREEZE = "冻结";
        public const string STATUS_WAIT = "待审";
        public const string PASSWORD_ERR = "密码错误";
        public const string ON="准入";
        public const string OFF="禁入";
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

    public class ErrorMsgConst
    {
 
        public const string BALANCE_NOT_ENOUGH = "积分不足";
        public const string OPERATE_FAILED = "操作失败";
        public const string OPERATE_SUCCESS = "操作成功";

        public const string USER_NOT_SELF = "用户名不能为自己";
        public const string USER_NOT_EXITED = "用户不存在";

        public const string USER_NOT_MATCH = "用户信息不匹配";
        public const string USER_IS_WAIT = "用户处于待审状态";
        public const string USER_IS_FREEZE = "用户处于冻结状态";


        public const string REM_USER_IS_NOT_EXISTED = "推荐人不存在";

        public const string REGIST_NOT_OPEN = "系统目前未开放注册";
        public const string USERNAME_EXIST = "该用户名已被注册";

   
    }
    public class SysConstants
    {
        public const string SUCCESS = "success";

        public const char OS_BROWSER_SPLIT = ',';

        public static string[] OS_LIST = new string[]{"All","Linux","xp/win7","IOS"};
        public static string[] BROWSER_LIST = new string[] { "All", "Google", "IEs" };

        public const string REG_TYPE_0 = "停止注册";
        public const string REG_TYPE_2 = "自由注册";
        public const string REG_TYPE_1 = "引荐注册";

        public const string SCORE_USER_OPEN = "开户";
        public const string SCORE_BANK_WIN = "庄胜";
        public const string SCORE_BANK_LOSE = "庄负";
        public const string SCORE_PLAYER_WIN = "闲胜";
        public const string SCORE_PLAYER_LOSE = "闲负";
        public const string SCORE_LEND_OUT = "借出";
        public const string SCORE_BORROW_IN = "借进";
        public const string SCORE_REPAY_OUT = "还款";
        public const string SCORE_REPAY_IN = "收款";
        public const string SCORE_APPROVE_IN = "申借";
        public const string SCORE_SEND_OUT = "划出";
        public const string SCORE_REVC_IN = "划入";
        public const string SCORE_REVE_TAX = "收税";
        public const string SCORE_SEND_TAX = "缴税";
      
    }
}