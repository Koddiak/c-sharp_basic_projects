using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //--
            //string text = "Hello";
            //System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt", text);

            //--
            //Random rnd = new Random();
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //--
            //return Content("Hello");

            //--
            //return RedirectToAction("Contact");

            //--
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Bruce";
            user.LastName = "Wayne";
            user.Age = 30;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}