using System;
using System.IO;
using System.Security.AccessControl;
using System.Web.Mvc;
using MVCLesson4_big.Models;

namespace MVCLesson4_big.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Server.MapPath("\\Content"), "myfile.txt");

                System.IO.File.AppendAllLines(filepath, new[] { loginModel.Login, loginModel.Pass });

                ViewBag.Result ="OK";
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
            }
            
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel registration)
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Server.MapPath("\\Content"), "myfile.txt");

                System.IO.File.AppendAllLines(filepath, new[] { registration.Login, registration.Pass, registration.PassSec, registration.Email });

                ViewBag.Result = "OK";
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
            }

            return View();
        }
    }
}