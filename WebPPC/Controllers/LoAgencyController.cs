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
        team12Entities db = new team12Entities();
        public ActionResult List()
        {
            var product = db.PROPERTies.ToList().Where(x => x.UserID==int.Parse(Session["UserID"].ToString()));
            int count = product.Count(x => x.UserID == int.Parse(Session["UserID"].ToString()));
            ViewBag.count = count;
            return View(product);

        }
        public ActionResult Edit(int id)
        {
            var property = db.PROPERTies.SingleOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p)
        {
            var property = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            property.PropertyName = p.PropertyName;
            property.UnitPrice = p.UnitPrice;
            property.Price = p.Price;
            property.BathRoom = p.BathRoom;
            property.BedRoom = p.BedRoom;
            property.Content = p.Content;
            property.Create_post = p.Create_post;
            property.Created_at = p.Created_at;
            property.DISTRICT = p.DISTRICT;
            property.STREET = p.STREET;
            property.WARD = p.WARD;
            property.Area = p.Area;
            property.Status_ID = p.Status_ID;


            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {

            //Lấy ra đối tượng sách theo mã 
            PROPERTY property = db.PROPERTies.SingleOrDefault(x => x.ID == id);
            if (property == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(property);

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var pj = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            db.PROPERTies.Remove(pj);
            db.SaveChanges();
            return RedirectToAction("List", "LoAgency");
        }
    }
}