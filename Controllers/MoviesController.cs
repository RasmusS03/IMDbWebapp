using System.Diagnostics;
using IMDbWebapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMDbWebapp.Controllers
{
    public class MoviesController : Controller
{
    public IActionResult Index() //Framsidan för filmer, visar alla filmer i databasen
    {
        var theme = Request.Cookies["theme"];
            //default theme is light if no cookie is set
        if (string.IsNullOrEmpty(theme))
            {
                theme = "light";
            }
        ViewBag.Theme = theme;

        return View(FakeDatabase.Movies);
    }

    public IActionResult Details(int id) //Visar detaljer för en specifik film baserat på dess ID
    {
        var theme = Request.Cookies["theme"];
        if (string.IsNullOrEmpty(theme))
        {
            theme = "light";
        }
        ViewBag.Theme = theme;

        var movie = FakeDatabase.Movies.FirstOrDefault(m => m.MovieID == id);

        return View(movie);
    }

    public IActionResult Create() 
    {
        var theme = Request.Cookies["theme"];
            //default theme is light if no cookie is set
        if (string.IsNullOrEmpty(theme))
            {
                theme = "light";
            }
        ViewBag.Theme = theme;

        return View();
    }

    [HttpPost]
    public IActionResult Create(Movie movie)
    {
        movie.MovieID = FakeDatabase.Movies.Count + 1;

        FakeDatabase.Movies.Add(movie);

        return RedirectToAction("Index");
    }
}
}
