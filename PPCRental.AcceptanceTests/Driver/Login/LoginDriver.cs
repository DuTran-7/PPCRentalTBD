using System;
using WebPPC.Controllers;
using System.Web.Mvc;


namespace PPCRental.AcceptanceTests.Driver.Login
{
    class LoginDriver


    {
        public ActionResult _result;
        public void index()
        {
            using (var login = new HomeController())
            {
                _result = login.Login();
            }
        }
    }
}
