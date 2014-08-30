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
    public class HomeController : BaseController
    {
        PlatService platService = ServiceContext.getInstance().getPlatService();

        public ActionResult Index(String msg)
        {
            ViewBag.Msg = msg;
            return View();
        }

       public ActionResult SystemManage()
       {
           //ViewBag.Msg = msg;
           SystemInfoModel sysInfo=  ServiceContext.getInstance().getSysInfoService().loadSysInfo() ;
            
           ViewBag.SysInfo=sysInfo;
           return View();
       }

       public ActionResult modifySysInfo(SystemInfoModel sysInfo)
       {
           //ViewBag.Msg = msg;
           ServiceContext.getInstance().getSysInfoService().saveSysInfo(sysInfo);
           
           return RedirectToAction("Hall", "Game");
       }
    }
}
