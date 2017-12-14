using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebPPC.Controllers;
using WebPPC.Models;
using WebPPC.Areas.Admin.Controllers;
using WebPPC.AcceptanceTests.Common;


namespace WebPPC.AcceptanceTest.Driver.AdminDriver
{
    public class Admin
    {
        public ActionResult _result;
        public void Index()
        {
            using(var admin = new ProductAdminController()) { _result = admin.Index(); }
        }

        public void ShowProject()
        {
            var admin = new ProductAdminController();
            //Arrange
            var expected = admin.Index();

            //Assert
            WebPPCAssertion.HomeScreenShowListProject(expected);
        }
    }
}
