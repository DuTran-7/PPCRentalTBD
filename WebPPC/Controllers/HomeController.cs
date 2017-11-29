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
        DemoPPCRentalEntities1 db = new DemoPPCRentalEntities1();
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
        //[HttpGet]
        //public ActionResult Signup()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Signup(USER user, SignUpModel model)
        //{
        //    if(ModelState.IsValid)
        //    {

        //    }
        //    return View(model);
        //    var sig = new USER();
        //    sig.Address = user.Address;
        //    sig.Email = user.Email;
        //    sig.FullName = user.FullName;
        //    sig.Password = user.Password;
        //    sig.Phone = user.Phone;
        //    db.USERs.Add(sig);
        //    db.SaveChanges();
        //    return RedirectToAction("Index", "Home");
        //}
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpModel model)
        {
            if(ModelState.IsValid)
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
                model = new SignUpModel();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Đăng ký không thành công");
            }
            return View(model);
        }
        
    }
}