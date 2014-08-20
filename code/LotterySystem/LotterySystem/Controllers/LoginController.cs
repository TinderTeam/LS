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
        public ActionResult Login(LoginModel model, string returnUrl)
        {

            if (ModelState.IsValid && loginSerivce.Login(model.UserName, model.Password))
            {
               
                ViewBag.User =loginSerivce.getLoginUser(model.UserName);
                return RedirectToAction("Index", "Home");
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            ModelState.AddModelError("", "提供的用户名或密码不正确。");
            return View(model);
        }

    }
}
