using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LotterySystem.Models;
namespace LotterySystem
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }

        void Session_Start(object sender,EventArgs e)　
        {
　　       Application.Lock();
  
　　 
　　　  　 Application.UnLock();
　    　}
       void Session_End(object sender,EventArgs e)　
　   　{
　　　  　//在会话结束时运行的代码。　
　　　　  //注意:只有在Web.config文件中的sessionstate模式设置为
　　　　   //InProc时，才会引发Session_End事件。如果会话模式设置为StateServer　
　　　　   //或SQLServer，则不会引发该事件。
　　　　   //对Application加锁以防并行性
　　　   　Application.Lock();
　　　　   //减少一个在线人数
           SysCatch.OnlinePlayerNum--;
　　　　   //解锁
　　　　   Application.UnLock();
　　    }
    }
}