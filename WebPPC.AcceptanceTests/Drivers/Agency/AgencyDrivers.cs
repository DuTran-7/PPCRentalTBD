using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebPPC.Models;
using WebPPC.Controllers;
using System.Web.Mvc;
using WebPPC.AcceptanceTests.Common;
using WebPPC.AcceptanceTests.Support;
using System;
using Moq;
using System.Web;

namespace WebPPC.AcceptanceTests.Drivers.Agency
{
    public class AgencyDrivers
    {
        private ActionResult _result;
        public void GotoLogin()
        {
            using (var controller = new AgencyController())
            {
                _result = controller.Login();
            }
        }

        public void Login(string email, string password)
        {

            using (var controller = new AgencyController())
            {
                var mContext = new Mock<ControllerContext>();
                var mSession = new Mock<HttpSessionStateBase>();
                mContext.SetupGet(c => c.HttpContext.Session).Returns(mSession.Object);
                controller.ControllerContext = mContext.Object;
                _result = controller.Login(email,password);
            }
        }

        public void FilterProject(string propertyName)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(propertyName, null, null, null, null,null);
            }
        }
    }
}
