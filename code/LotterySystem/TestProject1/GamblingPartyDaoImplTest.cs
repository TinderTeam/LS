using LotterySystem.Dao.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using LotterySystem.Po;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///这是 GamblingPartyDaoImplTest 的测试类，旨在
    ///包含所有 GamblingPartyDaoImplTest 单元测试
    ///</summary>
    [TestClass()]
    public class GamblingPartyDaoImplTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///creatGamblingParty 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[UrlToTest("http://localhost:18263")]
        public void creatGamblingPartyTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            GamblingParty gamblingParty = new GamblingParty(); // TODO: 初始化为适当的值
            
            gamblingParty.GameName = "三合";
            gamblingParty.BankerStartTime = DateTime.Today;
            gamblingParty.BankerEndTime= DateTime.Today;
            
            target.creatGamblingParty(gamblingParty);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///deleteGamblingPartyByGamblingPartyID 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void deleteGamblingPartyByGamblingPartyIDTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            string gamblingPartyID = string.Empty; // TODO: 初始化为适当的值
            target.deleteGamblingPartyByGamblingPartyID(gamblingPartyID);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///getAll 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getAllTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            List<GamblingParty> expected = null; // TODO: 初始化为适当的值
            List<GamblingParty> actual;
            actual = target.getAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getGamblingPartyByGamblingPartyID 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getGamblingPartyByGamblingPartyIDTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            string gamblingPartyID = string.Empty; // TODO: 初始化为适当的值
            GamblingParty expected = null; // TODO: 初始化为适当的值
            GamblingParty actual;
            actual = target.getGamblingPartyByGamblingPartyID(gamblingPartyID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getGamblingPartyByGameAndRoom 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getGamblingPartyByGameAndRoomTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            string game = string.Empty; // TODO: 初始化为适当的值
            string room = string.Empty; // TODO: 初始化为适当的值
            List<GamblingParty> expected = null; // TODO: 初始化为适当的值
            List<GamblingParty> actual;
            actual = target.getGamblingPartyByGameAndRoom(game, room);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///updateGamblingParty 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void updateGamblingPartyTest()
        {
            GamblingPartyDaoImpl target = new GamblingPartyDaoImpl(); // TODO: 初始化为适当的值
            GamblingParty gamblingParty = null; // TODO: 初始化为适当的值
            target.updateGamblingParty(gamblingParty);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
