using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Controllers
{
    public class PropertyController : Controller
    {
        Team12Entities1 model = new Team12Entities1();
        //
        // GET: /Property/
        public ActionResult Detail(int id)
        {
            PROPERTY product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}