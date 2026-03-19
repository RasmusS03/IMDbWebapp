using System.Diagnostics;
using IMDbWebapp.Models;
using Microsoft.AspNetCore.Mvc;


namespace IMDbWebapp.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {       
            var theme = Request.Cookies["theme"];
                //default theme is light if no cookie is set
                if (string.IsNullOrEmpty(theme))
                {
                    theme = "light";
                }
                ViewBag.Theme = theme;
            return View(FakeDatabase.Persons);
        }
    }
}