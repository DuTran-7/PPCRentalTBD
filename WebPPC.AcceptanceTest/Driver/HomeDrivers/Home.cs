using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebPPC.Controllers;
using WebPPC.Models;

namespace WebPPC.AcceptanceTest.Driver.HomeDrivers
{
    public class Home
    {
        public ActionResult result;
        public void Index()
        {
            using (var home = new HomeController()) { result = home.Index(); }
        }
    }
}
