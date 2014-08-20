using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Service.Login;

namespace LotterySystem.Service
{
    public class ServiceContext
    {
        static ServiceContext serviceContext;


        private LoginService loginService;

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
    }
}