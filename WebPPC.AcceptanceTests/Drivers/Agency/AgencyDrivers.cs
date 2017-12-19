using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebPPC.Models;
using WebPPC.Controllers;
using System.Web.Mvc;
using WebPPC.AcceptanceTests.Common;
using WebPPC.AcceptanceTests.Support;

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
                _result = controller.Login(email,password);
            }
        }
    }
}
