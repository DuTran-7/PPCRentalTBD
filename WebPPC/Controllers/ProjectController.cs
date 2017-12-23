using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;
using System.IO;
using System.Net;
using System.Net.Mail;
namespace WebPPC.Controllers
{
    public class ProjectController : Controller
    {

        team12Entities db = new team12Entities();
       
        public ActionResult Index()
        {
            var product = db.PROPERTies.ToList();
            return View(product);
        }
        public ActionResult SearchI()
        {
            var pj = db.PROPERTies.ToList();
            return View(pj);
        }
        [HttpGet]
        public ActionResult Search(string name, string price, string bathroom, string bedroom, string packingplace, string area)
        {

            var pj = db.PROPERTies.ToList().Where(x => (x.PropertyName.Contains(name) && name != "")
                || (x.Content.Contains(name) && name != "")
                || x.Price.Equals(int.Parse(price == "" ? "0" : price))
                || x.BedRoom.Equals(int.Parse(bedroom == "" ? "0" : bedroom))
               || x.BathRoom.Equals(int.Parse(bathroom == "" ? "0" : bathroom))
               || x.PackingPlace.Equals(int.Parse(packingplace == "" ? "0" : packingplace))
                 );

            return View(pj);
        }
        public ActionResult Detail(int id)
        {
            PROPERTY product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
        [HttpGet]
        public ActionResult PostProject()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult PostProject(HttpPostedFileBase Avatar, PROPERTY property, HttpPostedFileBase Image, PostModel model, List<string> feature)
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
                //pro.Images = image;
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
                pro.UnitPrice = model.UnitPrice;
                
                //add feature

                var fetur = new PROPERTY_FEATURE();
                if (feature != null)
                {
                    foreach (string fetus in feature)
                    {
                        //PROPERTY_FEATURE profeature = new PROPERTY_FEATURE();
                       // fetur.Property_ID = qqq.ID;
                        fetur.Feature_ID = db.FEATUREs.SingleOrDefault(x => x.FeatureName == fetus).ID;
                        fetur.Property_ID = property.ID;
                        //fetur.Feature_ID = 1;
                        db.PROPERTY_FEATURE.Add(fetur);

                    }
                }

                pro.Status_ID = model.Status_ID;
                pro.Updated_at = DateTime.Now;
                pro.Created_at = DateTime.Now;
                pro.UserID = (int)Session["UserID"];
               db.PROPERTies.Add(pro);
               db.SaveChanges();
                //ViewBag.Success = "Đăng ký thành công";
                model = new PostModel();
                return RedirectToAction("List", "Project");
            }
            else
            {
                ModelState.AddModelError("", "Đăng bài không thành công, vui lòng kiểm tra lại các trường thông tin của bạn");
            }
            return View(model);
        }
        public ActionResult List()
        {
            var product = db.PROPERTies.ToList().Where(x => x.UserID == int.Parse(Session["UserID"].ToString()));
            int count = product.Count(x => x.UserID == int.Parse(Session["UserID"].ToString()));
            ViewBag.count = count;
            return View(product);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name, string email, string phone, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("k21t1team2@gmail.com", "Support");//Email Agency
                    var receiveremail = new MailAddress("ppcrental2017@gmail.com", "PPC Rental"); //Emai Company

                    var password = "Team2ppc";// Password Email  
                    var sub = name;
                    var body = " " + "Name: " + name + "\n" + " Email: " + email + "\n" + " Phone: " + phone + "\n" + " Message: " + message;
                    // Message Content
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)

                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = "User",
                        Body = body
                    }
                    )
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "There are some problem in sending email";
            }
            return View();
        }
        public ActionResult AboutUS()
        {
            List<ABOUTU> minhphe = new List<ABOUTU>();
            minhphe = db.ABOUTUS.ToList();
            return View(minhphe);
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
            return RedirectToAction("List", "Project");
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