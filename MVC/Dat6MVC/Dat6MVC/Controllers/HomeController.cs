using Dat6MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dat6MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetServerTime()

        {

            System.Threading.Thread.Sleep(5000);

            return PartialView();

        }
        static List<User> users = new List<User>();
        public ActionResult GetAllUsers()

        {

            return PartialView(users);

        }
        public ActionResult CreateUser()

        {

            return View();

        }

        [HttpPost]

        public ActionResult CreateUser(User u)

        {

            users.Add(u);

            return RedirectToAction("GetAllUsers");

        }
        
        
        

      


    }
}