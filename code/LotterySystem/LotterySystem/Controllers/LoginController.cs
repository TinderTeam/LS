using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Models;
using LotterySystem.Service.Login;
using LotterySystem.Service;
namespace LotterySystem.Controllers
{
    public class LoginController : Controller
    {

        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        LoginService loginSerivce = ServiceContext.getInstance().getLoginService();

        //
        // GET: /Login/
        /// <summary>
        /// 系统用户登陆
        /// </summary>
        /// <returns></returns>
        ///   
        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {


            try
            {

                loginSerivce.Login(model.UserName, model.Password);
                Session["SystemUser"] = loginSerivce.getLoginUser(model.UserName);

                ServiceContext.getInstance().getLogService().recordLoginLog(model.UserName, "成功", model.Os, model.Broswer);

            }
            catch (SystemException ex)
            {
                log.Error("login failed", ex);
                ServiceContext.getInstance().getLogService().recordLoginLog(model.UserName, "失败", model.Os, model.Broswer);
                return RedirectToAction("Index", "Home", new { msg = ex.Message });
            }

            return RedirectToAction("Hall", "Game");
        }


        [HttpPost]
        public ActionResult Register(UserRigistForm model)
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

            try
            {
                string result = loginSerivce.register(model);
            }
            catch (Exception ex)
            {
                log.Error("register failed", ex);
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
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
            
            return View();
        }

        public ActionResult LogOff()
        {
            Session["SystemUser"] = null;
            Session["CurrentRoom"] = null;
            Session["CurrentGame"] = null;
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
