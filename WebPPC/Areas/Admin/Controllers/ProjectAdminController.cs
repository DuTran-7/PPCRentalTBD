using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Areas.Admin.Controllers
{
    public class ProjectAdminController : Controller
    {
        team12Entities model = new team12Entities();
        //
        // GET: /Admin/ProductAdmin/
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                var userid = int.Parse(Session["UserID"].ToString());
                var emp = model.PROPERTies.OrderByDescending(x => x.ID).ToList();
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
            // var property = model.PROPERTies.SingleOrDefault(x => x.ID == id);
            //var picture = model.PICTUREs.SingleOrDefault(x => x.id == id);
            var property = model.PROPERTies.Find(id);
            return View(property);
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PROPERTY p, List<string> feature, List<HttpPostedFileBase> Images)
        {
            PROPERTY proper = model.PROPERTies.Find(p.ID);
            var property = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            var feat = model.PROPERTY_FEATURE.Where(x => x.Property_ID == p.ID).ToList();
            var image = model.PICTUREs.Where(x => x.Property_id == p.ID);
            model.PICTUREs.RemoveRange(image);
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
            foreach (HttpPostedFileBase img in Images)
            {
                if (img != null)
                {
                    if (img.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(img.FileName);
                        var path = Path.Combine(Server.MapPath("~/img/"), filename);
                        img.SaveAs(path);
                        PICTURE pic = new PICTURE();
                        pic.Name_Image = filename;
                        pic.Property_id = property.ID;
                        model.PICTUREs.Add(pic);
                    }
                    else
                    {
                        model.SaveChanges();
                    }

                }
                else
                {
                    model.SaveChanges();
                }
            }
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


            PROPERTY property = model.PROPERTies.SingleOrDefault(x => x.ID == id);
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

            PROPERTY property = model.PROPERTies.SingleOrDefault(x => x.ID == id);
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
            PROPERTY property = model.PROPERTies.SingleOrDefault(x => x.ID == id);
            if (property == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            model.PROPERTies.Remove(property);
            model.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}