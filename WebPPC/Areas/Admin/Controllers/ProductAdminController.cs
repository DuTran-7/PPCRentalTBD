﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPPC.Models;
namespace WebPPC.Areas.Admin.Controllers
{
    public class ProductAdminController : Controller
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
                return RedirectToAction("Login");
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            ViewBag.mgs = "";
            var user = model.USERs.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {

                    Session["FullName"] = user.FullName;
                    Session["UserID"] = user.ID;

                    if (int.Parse(user.Role) == 1)
                    {
                        return RedirectToAction("ProductAdmin", "Admin");
                    }
                    else
                    {
                        ViewBag.mgs = "Tài khoản không có quyền truy cập";
                        return RedirectToAction("Login", "ProductAdmin", new { area = "Admin" });

                    }



                }

            }

            else
            {
                ViewBag.mgs = "Tài khoản không có quyền truy cập";
            }
            return RedirectToAction("Login", "ProductAdmin", new { area = "Admin" });
        }

        public ActionResult Logout()
        {
            if (Session["Fullname"] != null)
            {
                Session["Fullname"] = null;
                Session["UserID"] = null;
            }
            return RedirectToAction("ProductAdmin", "Admin");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var property = model.PROPERTies.SingleOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p)
        {
            var property = model.PROPERTies.FirstOrDefault(x => x.ID == id);
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