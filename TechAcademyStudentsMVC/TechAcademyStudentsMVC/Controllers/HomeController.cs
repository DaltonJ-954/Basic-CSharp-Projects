using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcademyStudentsMVC.Models;

namespace TechAcademyStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Paul",
                    LastName = "Eshore"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Nikola",
                    LastName = "Tesla"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Bruce",
                    LastName = "Wayans"
                }
            };
            return View(instructors);
        }
    }
}