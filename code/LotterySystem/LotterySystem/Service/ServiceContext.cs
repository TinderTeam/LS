using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Service.Login;
using LotterySystem.Service;

namespace LotterySystem.Service
{
    public class ServiceContext
    {
        static ServiceContext serviceContext;


        private LoginService loginService;
        private PlatService platService;
        private ConvertService convertService;
        private EntranceServcie entranceServcie;


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

        public LoginService getLoginService()
        {

            if (loginService == null)
            {
                loginService = new LoginService();
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