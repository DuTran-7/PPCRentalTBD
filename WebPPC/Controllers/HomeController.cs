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
        Team12Entities1 db = new Team12Entities1();
        public ActionResult Index()
        {
            List<PROPERTY> product = new List<PROPERTY>();
            product = db.PROPERTies.ToList();
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
                    return RedirectToAction("PostProject", "Post");
                }
            }

            else
            {
                ViewBag.mgs = "Tài khoản không tồn tại";
            }
            return View();
        }
    }
}