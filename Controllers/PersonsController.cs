using System.Diagnostics;
using IMDbWebapp.Models;
using Microsoft.AspNetCore.Mvc;


namespace IMDbWebapp.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDatabase.Persons);
        }
    }
}