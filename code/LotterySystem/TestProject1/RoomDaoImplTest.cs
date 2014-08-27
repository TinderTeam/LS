using LotterySystem.Dao;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using LotterySystem.Po;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///这是 RoomDaoImplTest 的测试类，旨在
    ///包含所有 RoomDaoImplTest 单元测试
    ///</summary>
    [TestClass()]
    public class RoomDaoImplTest
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
        ///RoomDaoImpl 构造函数 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void RoomDaoImplConstructorTest()
        {
            RoomDaoImpl target = new RoomDaoImpl();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///createRoom 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[UrlToTest("http://localhost:18263")]
        public void createRoomTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            Room room = new Room() ; // TODO: 初始化为适当的值
            room.GameName = "game3";

            room.RoomName = "aaaa4";
            target.createRoom(room);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///deleteRoomByRoomName 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void deleteRoomByRoomNameTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            string roomName = string.Empty; // TODO: 初始化为适当的值
            target.deleteRoomByRoomName(roomName);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///getAll 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
       // [HostType("ASP.NET")]
       // [UrlToTest("http://localhost:18263")]
        public void getAllTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            List<Room> expected = null; // TODO: 初始化为适当的值
            List<Room> actual;
            actual = target.getAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getRoomByGame 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[UrlToTest("http://localhost:18263")]
        public void getRoomByGameTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            string gameName = "game2"; // TODO: 初始化为适当的值
            List<Room> expected = null; // TODO: 初始化为适当的值
            List<Room> actual;
            actual = target.getRoomByGame(gameName);
            Console.Write(actual[0].GameName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getRoomByGameNameAndStatus 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getRoomByGameNameAndStatusTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            string gameName = string.Empty; // TODO: 初始化为适当的值
            string status = string.Empty; // TODO: 初始化为适当的值
            List<Room> expected = null; // TODO: 初始化为适当的值
            List<Room> actual;
            actual = target.getRoomByGameNameAndStatus(gameName, status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getRoomByName 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getRoomByNameTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            string roomName = string.Empty; // TODO: 初始化为适当的值
            Room expected = null; // TODO: 初始化为适当的值
            Room actual;
            //actual = target.getRoomByName(roomName);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///getRoomListByGameAndHoster 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void getRoomListByGameAndHosterTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            string gameName = string.Empty; // TODO: 初始化为适当的值
            string hoster = string.Empty; // TODO: 初始化为适当的值
            List<Room> expected = null; // TODO: 初始化为适当的值
            List<Room> actual;
            actual = target.getRoomListByGameAndHoster(gameName, hoster);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///updateRoom 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost:18263")]
        public void updateRoomTest()
        {
            RoomDaoImpl target = new RoomDaoImpl(); // TODO: 初始化为适当的值
            Room room = null; // TODO: 初始化为适当的值
            target.updateRoom(room);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
