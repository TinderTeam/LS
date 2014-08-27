﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Service;
using LotterySystem.Models;

namespace LotterySystem.Controllers
{
    public class UserController : Controller
    {
        private UserService userService = ServiceContext.getInstance().getUserService();

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserAccount()
        {
            return View();
        }
        public ActionResult UserInfo(String userName,String operate)
        {
            UserModel user = userService.getUserByName(userName);
            if(null == user)
            {
                user = new UserModel();
            }
            ViewBag.User = user;
            ViewBag.Operate = operate;
            return View();
        }

        public ActionResult UserManage(String userName)
        {
            List<UserModel> userList = userService.getUserList(userName);
            ViewBag.UserList = userList;
            ViewBag.UserListCount = userList.Count;
                 
            return View();
        }
        public ActionResult NewUser()
        {
            return View();
        }
        public ActionResult UserEdit()
        {
            return View();
        }
        public ActionResult AccountBorrow()
        {
            return View();
        }
        public ActionResult AccountBack()
        {
            return View();
        }
    }
}
