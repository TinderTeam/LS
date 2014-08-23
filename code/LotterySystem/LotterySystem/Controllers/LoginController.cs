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

            if (ModelState.IsValid && loginSerivce.Login(model.UserID, model.Password))
            {

                Session["SystemUser"] = loginSerivce.getLoginUser(model.UserID);
                return RedirectToAction("Hall", "Game");
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            ViewBag.Msg = "密码错误";
            return RedirectToAction("Index", "Home", new {Msg= "请输入正确的用户名和密码！" });
        }


        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }


        //
        // POST: /Account/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
        

            return RedirectToAction("Index", "Home");
        }
    }
}
