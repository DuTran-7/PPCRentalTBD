using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Controllers
{
    public class AgencyController : Controller
    {
        team12Entities1 db = new team12Entities1();
        public ActionResult Index()
        {
            var product = db.PROPERTY.ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = db.USER.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    Session["FullName"] = user.FullName;
                    Session["UserID"] = user.ID;
                    if (int.Parse(user.Role) == 1)
                    {
                        return RedirectToAction("ProjectAdmin", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("List", "Project");
                    }
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
        public ActionResult SignUp(SignUpModel model)
        {

            if (ModelState.IsValid)
            {
                var siag = db.USER.FirstOrDefault(x => x.Email == model.Email);
                if (siag == null)
                {
                    var sig = new USER();
                    sig.Address = model.Address;
                    sig.Email = model.Email;
                    sig.FullName = model.FullName;
                    sig.Password = model.Password;
                    sig.Phone = model.Phone;
                    sig.Role = "0";
                    sig.Status = true;
                    db.USER.Add(sig);
                    db.SaveChanges();
                   ViewBag.Success = "Đăng ký thành công";
                    model = new SignUpModel();
                    return RedirectToAction("Login", "Agency");
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
            var us = db.USER.Single(x => x.ID == xx);
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
