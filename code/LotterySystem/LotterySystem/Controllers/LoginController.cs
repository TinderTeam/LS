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
    public  class LoginController : Controller
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
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {


            try
            {

                loginSerivce.Login(model.UserName, model.Password);
                Session["SystemUser"] = loginSerivce.getLoginUser(model.UserName);

                ServiceContext.getInstance().getLogService().recordLoginLog(model.UserName, "成功", "os", "browser");

            }
            catch (SystemException ex)
            {
                log.Error("login failed", ex);
                ServiceContext.getInstance().getLogService().recordLoginLog(model.UserName, "失败", "os", "browser");
                return RedirectToAction("Index", "Home", new { msg = ex.Message });
            }

            return RedirectToAction("Hall", "Game");
        }
               


        public ActionResult Register()
        {
            return View();
        }


        public ActionResult LogOff()
        {
            Session["SystemUser"] = null;
            Session["CurrentRoom"] = null;
            Session["CurrentGame"] = null;
            
            return RedirectToAction("Index", "Home");
        }
    }
}
