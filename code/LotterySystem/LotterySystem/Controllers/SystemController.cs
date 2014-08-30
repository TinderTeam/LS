using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Service;
using LotterySystem.Models;

namespace LotterySystem.Controllers
{
    public class SystemController : BaseController
    {
        public ActionResult SystemManage()
        {
            //ViewBag.Msg = msg;
            SystemInfoModel sysInfo = ServiceContext.getInstance().getSysInfoService().loadSysInfo();

            ViewBag.SysInfo = sysInfo;
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
