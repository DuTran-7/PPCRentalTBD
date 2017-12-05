using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Controllers
{
    public class PostController : Controller
    {
        Team12Entities1 db = new Team12Entities1();
        // GET: /Post/
        [HttpGet]
        public ActionResult Post()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Post(PROPERTY property, HttpPostedFileBase Avatar)
        {

            string avatar = "";
            if (Avatar.ContentLength > 0)
            {
                var filename = Path.GetFileName(Avatar.FileName);
                var path = Path.Combine(Server.MapPath("~/img"), filename);
                Avatar.SaveAs(path);
                avatar = filename;
            }
            var pro = new PROPERTY();
            pro.PropertyName = property.PropertyName;
            pro.PROPERTY_TYPE = property.PROPERTY_TYPE;
            pro.Avatar = avatar;
            pro.Images = property.Images;
            pro.DISTRICT = property.DISTRICT;
            pro.STREET = property.STREET;
            pro.Price = property.Price;
            pro.Area = property.Area;
            pro.BathRoom = property.BathRoom;
            pro.BedRoom = property.BedRoom;
            pro.PackingPlace = property.PackingPlace;
            pro.Content = property.Content;
            pro.USER.Email = property.USER.Email;
            pro.USER.Phone = property.USER.Phone;
            pro.UserID = int.Parse(Session["UserID"].ToString());
            //pro.Create_post = DateTime.Now.;
            pro.Updated_at = DateTime.Now;
            db.PROPERTies.Add(pro);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult PostProject()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult PostProject( HttpPostedFileBase Avatar, USER us,HttpPostedFileBase Image,PostModel model)
        {
            if (ModelState.IsValid)
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
                pro.PropertyName = model.PropertyName;
                pro.PropertyType_ID = model.PropertyType_ID;
                pro.Avatar = avatar;
                pro.Images = image;
                //pro.DISTRICT = model.DISTRICT;
                pro.District_ID = model.District_ID;
                pro.Street_ID = model.Street_ID;
                pro.Ward_ID = model.Ward_ID;
                //pro.STREET = model.STREET;
                pro.Price = model.Price;
                pro.Area = model.Area;
                pro.BathRoom = model.BathRoom;
                pro.BedRoom = model.BedRoom;
                pro.PackingPlace = model.PackingPlace;
                pro.Content = model.Content;
                //pro.UserID = model.UserID;
                pro.UnitPrice = model.UnitPrice;
                //pr.Email = us.Email;
                //pr.Phone = us.Phone;
                //pro.Create_post = DateTime.Now.;

                pro.Status_ID = model.Status_ID;
                pro.Updated_at = DateTime.Now;
                pro.Created_at = DateTime.Now;
                pro.UserID = (int)Session["UserID"];
                db.PROPERTies.Add(pro);
                db.SaveChanges();
                //ViewBag.Success = "Đăng ký thành công";
                model = new PostModel();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Đăng bài không thành công, vui lòng kiểm tra lại các trường thông tin của bạn");
            }
            return View(model);
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