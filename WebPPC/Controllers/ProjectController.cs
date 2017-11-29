using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;
namespace WebPPC.Controllers
{
    public class ProjectController : Controller
    {

        DemoPPCRentalEntities1 model = new DemoPPCRentalEntities1();
        public ActionResult ProjectI()
        {
            var pj = model.PROPERTies.ToList();
            return View(pj);
        }
        [HttpGet]
        public ActionResult Project(string name, string price, string bathroom, string bedroom, string packingplace, string area)
        {

            var pj = model.PROPERTies.ToList().Where(x => (x.PropertyName.Contains(name) && name != "")
                || (x.Content.Contains(name) && name != "")
                || x.Price.Equals(int.Parse(price == "" ? "0" : price))
                || x.BedRoom.Equals(int.Parse(bedroom == "" ? "0" : bedroom))
               || x.BathRoom.Equals(int.Parse(bathroom == "" ? "0" : bathroom))
               || x.PackingPlace.Equals(int.Parse(packingplace == "" ? "0" : packingplace))
                  || (x.Avatar.Contains(area) && area != ""));

            return View(pj);
        }
    }
}