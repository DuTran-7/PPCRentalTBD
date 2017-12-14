using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPPC.Controllers;
using System.Web.Mvc;

namespace UnitTestChangePw
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestMethodChangePwValid()
        {
            HomeController home = new HomeController();
            //  ActionResult result = home.ChangePw("1", "2", "2");
            var controller = new HomeController();
            var actual = controller.ChangePw();
            var resuflt = controller.ChangePw();

            Assert.AreEqual(actual,resuflt);
        }
    }
}
