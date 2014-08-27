using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Service.Login;
using LotterySystem.Service.UserManage;
using LotterySystem.Service.GameManage;
using LotterySystem.Service.SysInfo;
namespace LotterySystem.Service
{
    public class ServiceContext
    {
        static ServiceContext serviceContext;


        private LoginService loginService;
        private PlatService platService;
        private EntranceServcie entranceServcie;
        private UserService userService;
        private LogService logService;
        private GameManageService gameManageService;
        private SysInfoService sysInfoService;
        private ScoreManageService scoreManageService;
        private ServiceContext()
        {

        }

        public static ServiceContext getInstance()
        {

            if (serviceContext == null)
            {
                serviceContext = new ServiceContext();                
            }
            return serviceContext;
        }

        public UserService getUserService()
        {

            if (userService == null)
            {
                userService = new UserServiceImpl();
            }
            return userService;
        }


        public LoginService getLoginService()
        {

            if (loginService == null)
            {
                loginService = new LoginServiceImpl();
            }
            return loginService;
        }

        public PlatService getPlatService()
        {

            if (platService == null)
            {
                platService = new PlatServiceImpl();
            }
            return platService;
        }

       

        public EntranceServcie getEntranceServcie()
        {

            if (entranceServcie == null)
            {
                entranceServcie = new EntranceServcieImpl();
            }
            return entranceServcie;
        }

        public LogService getLogService()
        {

            if (logService == null)
            {
                logService = new LogServiceImpl();
            }
            return logService;
        }

        public SysInfoService getSysInfoService()
        {

            if (sysInfoService == null)
            {
                sysInfoService = new SysInfoServiceImpl();
            }
            return sysInfoService;
        }


        public GameManageService getGameManageService()
        {

            if (gameManageService == null)
            {
                gameManageService = new GameManageServiceImpl();
            }
            return gameManageService;
        }
        public ScoreManageService getScoreManageService()
        {
            if (scoreManageService == null)
            {
                scoreManageService = new ScoreManageServiceImpl();
            }
            return scoreManageService;
        }

    }
}