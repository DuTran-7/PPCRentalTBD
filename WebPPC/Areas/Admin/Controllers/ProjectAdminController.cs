﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Areas.Admin.Controllers
{
    public class ProjectAdminController : Controller
    {
        team12Entities1 model = new team12Entities1();
        //
        // GET: /Admin/ProductAdmin/
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                var userid = int.Parse(Session["UserID"].ToString());
                var emp = model.PROPERTY.OrderByDescending(x => x.ID).ToList();
                return View(emp);
            }
            else
            {
                return RedirectToAction("Login", "Sale", new { area = "Admin" });
            }
        }
       
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var property = model.PROPERTY.SingleOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, PROPERTY p, List<string> feature)
        {
            PROPERTY proper = model.PROPERTY.Find(p.ID);
            var property = model.PROPERTY.FirstOrDefault(x => x.ID == id);
            var feat = model.PROPERTY_FEATURE.Where(x => x.Property_ID == p.ID).ToList();
            model.PROPERTY_FEATURE.RemoveRange(feat);

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

            //add feature
            
        //    foreach (var featu in feature)
        //    {
        //        PROPERTY_FEATURE proferty_fea = new PROPERTY_FEATURE();
               
        //        proferty_fea.Feature_ID = model.FEATUREs.SingleOrDefault(x => x.FeatureName == featu).ID;
        //        proferty_fea.Property_ID = p.ID;
        //        model.PROPERTY_FEATURE.Add(proferty_fea);
        //    }

            model.SaveChanges();
            return RedirectToAction("Index");




        }
        public ActionResult Details(int id)
        {


            PROPERTY property = model.PROPERTY.SingleOrDefault(x => x.ID == id);
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

            PROPERTY property = model.PROPERTY.SingleOrDefault(x => x.ID == id);
            if (property == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(property);
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult AcceptDelete(int id)
        {
            PROPERTY property = model.PROPERTY.SingleOrDefault(x => x.ID == id);
            if (property == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            model.PROPERTY.Remove(property);
            model.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}