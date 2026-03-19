using System.Diagnostics;
using IMDbWebapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMDbWebapp.Controllers
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
        
            var theme = Request.Cookies["theme"];
            //default theme is light if no cookie is set
            if (string.IsNullOrEmpty(theme))
            {
                theme = "light";
            }
            ViewBag.Theme = theme;

            ViewData["MovieCount"] = FakeDatabase.Movies.Count;
            ViewData["PersonCount"] = FakeDatabase.Persons.Count;
            ViewBag.Message = "Welcome to the IMDb Web App!";
            
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
        public IActionResult SetTheme(string theme)
        {
            Response.Cookies.Append("theme", theme, new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            });

            return RedirectToAction("Index");
        }
    }
}
