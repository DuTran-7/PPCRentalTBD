using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;
namespace WebPPC.Controllers
{
    public class LoAgencyController : Controller
    {
        //
        Team12Entities1 db = new Team12Entities1();
        public ActionResult List()
        {
            var product = db.PROPERTies.ToList().Where(x => x.UserID==int.Parse(Session["UserID"].ToString()));
            int count = product.Count(x => x.UserID == int.Parse(Session["UserID"].ToString()));
            ViewBag.count = count;
            return View(product);

        }
    }
}