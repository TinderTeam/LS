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
                    if (loginSerivce.Login(model.UserID, model.Password))
                    {

                        Session["SystemUser"] = loginSerivce.getLoginUser(model.UserID);
                        return RedirectToAction("Hall", "Game");
                    }
                    else
                    {
                        // 如果我们进行到这一步时某个地方出错，则重新显示表单
                        ModelState.AddModelError("", "提供的用户名或密码不正确。");
                        return View(model);
                    }
                }
                else
                {
                    // 如果我们进行到这一步时某个地方出错，则重新显示表单
                    ModelState.AddModelError("", "服务器已经满员，请稍后再尝试");
                    return View(model);
                }

            }// 如果我们进行到这一步时某个地方出错，则重新显示表单
            ModelState.AddModelError("", "请先登录系统");
            return View(model); 
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
