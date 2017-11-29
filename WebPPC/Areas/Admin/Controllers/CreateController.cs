﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;
namespace WebPPC.Areas.Admin.Controllers
{
    public class CreateController : Controller
    {
        Team12Entities1 db = new Team12Entities1();
        // GET: /Admin/Create/
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(PROPERTY property, HttpPostedFileBase Avatar, USER us, HttpPostedFileBase Image)
        {

            string avatar = "";
            if (Avatar.ContentLength > 0)
            {
                var filename = Path.GetFileName(Avatar.FileName);
                var path = Path.Combine(Server.MapPath("~/img"), filename);
                Avatar.SaveAs(path);
                avatar = filename;
            }
            string image = "";
            if (Image.ContentLength > 0)
            {
                var filename = Path.GetFileName(Image.FileName);
                var path = Path.Combine(Server.MapPath("~/img"), filename);
                Image.SaveAs(path);
                image = filename;
            }
            var pro = new PROPERTY();
            var pr = new USER();
            pro.PropertyName = property.PropertyName;
            pro.PropertyType_ID = property.PropertyType_ID;
            pro.Avatar = avatar;
            pro.Images = image;
            pro.DISTRICT = property.DISTRICT;
            pro.District_ID = property.District_ID;
            pro.Street_ID = property.Street_ID;
            pro.Ward_ID = property.Ward_ID;
            pro.STREET = property.STREET;
            pro.Price = property.Price;
            pro.Area = property.Area;
            pro.BathRoom = property.BathRoom;
            pro.BedRoom = property.BedRoom;
            pro.PackingPlace = property.PackingPlace;
            pro.Content = property.Content;
            pro.UserID = property.UserID;
            pro.UnitPrice = property.UnitPrice;
            pr.Email = us.Email;
            pr.Phone = us.Phone;
            //pro.Create_post = DateTime.Now.;
            pro.Updated_at = DateTime.Now;
            pro.Created_at = DateTime.Now;
            db.PROPERTies.Add(pro);
            db.USERs.Add(pr);
            db.SaveChanges();
            return RedirectToAction("Index", "ProductAdmin");
        }
        public JsonResult GetStreet(int District_id)
        {
            return Json(
            db.STREETs.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.StreetName }).ToList(),
            JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetWard(int District_id)
        {
            return Json(
            db.WARDs.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.WardName }).ToList(),
            JsonRequestBehavior.AllowGet);
        }
	}
}