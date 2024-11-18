using Microsoft.AspNetCore.Mvc;
using SessionASPCore.Models;
using System.Diagnostics;

namespace SessionASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("MyKey", "Obaydullah");
            TempData["SessionID"] = HttpContext.Session.Id;
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                HttpContext.Session.Remove("MyKey");
            }
            //HttpContext.Session.SetString("MyKey", "Obaydullah");
            return View();
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();
            }
            //HttpContext.Session.SetString("MyKey", "Obaydullah");
            return View();
        }

        public IActionResult Details ()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();
            }
            //HttpContext.Session.SetString("MyKey", "Obaydullah");
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
