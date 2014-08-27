using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LotterySystem.Service;
using LotterySystem.Po;
namespace LotterySystem.Controllers
{
    public class LogController : Controller
    {

        LogService manageService = ServiceContext.getInstance().getLogService();

        //
        // GET: /Log/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Log/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Log/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Log/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Log/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Log/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Log/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Log/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Loginlog()
        {
            List<LoginLog> logList = manageService.getLoginLogList();
            ViewBag.LoginLogList = logList;
            ViewBag.LoginLogListCount = logList.Count;
            return View();     
        }
    }
}
