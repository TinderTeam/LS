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
                                         
            if (ModelState.IsValid )
            {
                if (loginSerivce.LoginCheck())
                {
                    if (loginSerivce.Login(model.UserName, model.Password))
                    {
                        //Session中保存User
                        Session["SystemUser"] = loginSerivce.getLoginUser(model.UserName);

                        return RedirectToAction("Hall", "Game");
                    }
                    else
                    {
                        // 如果我们进行到这一步时某个地方出错，则重新显示表单
                        return RedirectToAction("Index", "Home", new { msg = "用户名或密码错误" });
                    }
                }
                else
                {
                    // 如果我们进行到这一步时某个地方出错，则重新显示表单
                    return RedirectToAction("Index", "Home", new { msg = "服务器已经满员，请稍后再尝试" });
                }

            }// 如果我们进行到这一步时某个地方出错，则重新显示表单
            return RedirectToAction("Index", "Home", new { msg = "信息填写有误" });
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
            Session["SystemUser"] = null;
            Session["CurrentRoom"] = null;
            Session["CurrentGame"] = null;
            
            return RedirectToAction("Index", "Home");
        }
    }
}
