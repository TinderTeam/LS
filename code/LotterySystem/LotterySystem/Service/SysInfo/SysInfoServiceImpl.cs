using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Models;
using LotterySystem.Po;
using LotterySystem.Dao;
using LotterySystem.Service;
using LotterySystem.Service.SysInfo;
namespace LotterySystem.Service.SysInfo
{
  
    public class SysInfoServiceImpl :SysInfoService
    {
        SysDao sysDao = DaoContext.getInstance().getSysDao();
        public SystemInfoModel loadSysInfo()
       {
           Sys sysInfo = sysDao.getFirst();
           return ConventService.toSysInfoModel(sysInfo);
       }
            
       public void saveSysInfo(SystemInfoModel sysInfo)
       {
           Sys newSysInfo = new Sys();
           newSysInfo.MaxPlayer = sysInfo.MaxPlayer;
           newSysInfo.RegistType = sysInfo.RegistType;
           DaoContext.getInstance().getSysDao().updateSys(newSysInfo);
       }
    }
}