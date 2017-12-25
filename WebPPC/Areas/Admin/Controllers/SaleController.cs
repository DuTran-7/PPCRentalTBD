using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;

namespace WebPPC.Areas.Admin.Controllers
{
    public class SaleController : Controller
    {
        team12Entities1 model = new team12Entities1();
        //
        // GET: /Admin/Sale/
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
 
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            ViewBag.mgs = "";
            var user = model.USER.FirstOrDefault(x => x.Email == email);
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
                        ViewBag.mgs = "Tài khoản không có quyền truy cập";
                        return RedirectToAction("Login", "Sale", new { area = "Admin" });

                    }



                }

            }

            else
            {
                ViewBag.mgs = "Tài khoản không có quyền truy cập";
            }
            return RedirectToAction("Login", "Sale", new { area = "Admin" });
        }

        public ActionResult Logout()
        {
            if (Session["Fullname"] != null)
            {
                Session["Fullname"] = null;
                Session["UserID"] = null;
            }
            return RedirectToAction("Sale", "Admin");
        }

	}
}