using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
using LotterySystem.Service.SysInfo;
using LotterySystem.Service;
namespace LotterySystem.Controllers
{
    public class HomeController : Controller
    {
        PlatService platService = ServiceContext.getInstance().getPlatService();
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
     
        public ActionResult Index(String msg)
        {
            SystemInfoModel sysInfo = ServiceContext.getInstance().getSysInfoService().loadSysInfo();
            if (null == sysInfo)
            {
                log.Error("can not get the system information");
            }
            else
            {
                ViewBag.RegistType = sysInfo.RegistType;
            }
            ViewBag.Msg = msg;
            return View();
        }


    }
}
