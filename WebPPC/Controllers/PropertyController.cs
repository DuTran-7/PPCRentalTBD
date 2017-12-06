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
        team12Entities model = new team12Entities();
        //
        // GET: /Property/
        public ActionResult Detail(int id)
        {
            PROPERTY product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}