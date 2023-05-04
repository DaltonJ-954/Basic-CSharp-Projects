using MVC101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC101.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Marion";
            user.LastName = "Oddly";
            user.Age = 25;
            user.Email = "bobbyHead@gmail.com";
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=10)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}