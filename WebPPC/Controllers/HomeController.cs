using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Controllers
{
    public class HomeController : Controller
    {
        team12Entities db = new team12Entities();
        public ActionResult Index()
        {
            var product = db.PROPERTies.ToList();
            return View(product);
        }
        public ActionResult Ind()
        {
            if (Session["UserID"] != null)
            {
                var userid = int.Parse(Session["UserID"].ToString());
                var emp = db.USERs.OrderByDescending(x => x.ID).ToList();
                return View(emp);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = db.USERs.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    Session["FullName"] = user.FullName;
                    Session["UserID"] = user.ID;
                    return RedirectToAction("List", "LoAgency");
                }
            }

            else
            {
                ViewBag.mgs = "Email chưa đăng kí, vui lòng đăng kí !";
            }
            return View();
        }

        public ActionResult Logout()
        {
            if (Session["Fullname"] != null)
            {
                Session["Fullname"] = null;
                Session["UserID"] = null;
            }
            return RedirectToAction("Login");
        }


        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SignUp(USER model)
        {

            if (ModelState.IsValid)
            {
                var siag = db.USERs.FirstOrDefault(x => x.Email == model.Email);
                if (siag == null)
                {
                    var sig = new USER();
                    sig.Address = model.Address;
                    sig.Email = model.Email;
                    sig.FullName = model.FullName;
                    sig.Password = model.Password;
                    sig.Phone = model.Phone;
                    sig.Status = true;
                    db.USERs.Add(sig);
                    db.SaveChanges();
                    ViewBag.Success = "Đăng ký thành công";
                    model = new USER();
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email đã tồn tại");

                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Đăng ký không thành công");

            }
            return View();

        }
        [HttpGet]
        public ActionResult ChangePw()
        {

            return View();

        }

        [HttpPost]
        public ActionResult ChangePw(string curPw, string newPw, string confimNewPw)
        {
            ViewBag.err = "";
            ViewBag.errr = "";
            int xx = (int)Session["UserID"];
            var us = db.USERs.Single(x => x.ID == xx);
            if (us.Password != curPw)
                ViewBag.err = "Current Password is incorect";
            if (newPw != confimNewPw)
                ViewBag.errr = "Password not same";
            if (ViewBag.err == "" && ViewBag.errr == "")
            {
                us.Password = newPw;
                db.SaveChanges();
                ViewBag.sc = "Change password success";
            }
            return View();

        }


    }
}
