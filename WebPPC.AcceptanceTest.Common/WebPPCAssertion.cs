using System.Collections.Generic;
using System.Linq;
using WebPPC.Models;
using WebPPC.Controllers;
using FluentAssertions;
using WebPPC.AcceptanceTest.Driver.AdminDriver;
using WebPPC.AcceptanceTest.Driver.HomeDrivers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebPPC.Areas.Admin.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebPPC.AcceptanceTest.Common
{
    class WebPPCAssertion
    {
        public static void HomeScreenShouldShowInOrder(ActionResult expected)
        {
            ProductAdminController admin = new ProductAdminController();
            ActionResult actionResult = admin.Index();
            ViewResult result = actionResult as ViewResult;
            Assert.AreEqual("admin.Index", expected.ToString());
        }
    }
}
