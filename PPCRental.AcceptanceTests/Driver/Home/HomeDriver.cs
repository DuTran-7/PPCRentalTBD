using WebPPC.Controllers;
using System.Web.Mvc;

namespace PPCRental.AcceptanceTests.Driver.Home
{
    class HomeDriver
    {
        private ActionResult _result;
        public void index()
        {
            using(var home = new HomeController()) { _result = home.Index(); }
        }

        public void PressSignin()
        {
            
        }
    }
}
