using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Service.Login;
using LotterySystem.Service.User;

namespace LotterySystem.Service
{
    public class ServiceContext
    {
        static ServiceContext serviceContext;


        private LoginService loginService;
        private PlatService platService;
        private ConvertService convertService;
        private EntranceServcie entranceServcie;
        private UserService userService;
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

        public ConvertService getConvertService()
        {

            if (convertService == null)
            {
                convertService = new ConventServiceImpl();
            }
            return convertService;
        }

        public EntranceServcie getEntranceServcie()
        {

            if (entranceServcie == null)
            {
                entranceServcie = new EntranceServcieImpl();
            }
            return entranceServcie;
        }

    }
}