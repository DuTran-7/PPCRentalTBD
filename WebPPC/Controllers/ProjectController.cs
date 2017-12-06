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

        team12Entities model = new team12Entities();
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
                 );

            return View(pj);
        }
        public JsonResult GetStreet(int District_id)
        {
            return Json(
            model.STREETs.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.StreetName }).ToList(),
            JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetWard(int District_id)
        {
            return Json(
            model.WARDs.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.WardName }).ToList(),
            JsonRequestBehavior.AllowGet);
        } 
    }
}