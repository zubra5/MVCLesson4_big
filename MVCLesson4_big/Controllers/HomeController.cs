using System;
using System.IO;
using System.Security.AccessControl;
using System.Web.Mvc;

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
        public ActionResult Login(string login, string pass)
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Server.MapPath("\\Content"), "myfile.txt");

                System.IO.File.AppendAllLines(filepath, new[] {login, pass});

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
        public ActionResult Register(string login, string pass, string secondpass, string email)
        {
            try
            {
                string filepath = String.Format("{0}\\{1}", Server.MapPath("\\Content"), "myfile.txt");

                System.IO.File.AppendAllLines(filepath, new[] { login, pass, secondpass, email });

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