using System.Diagnostics;
using IMDbWebapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMDbWebapp.Controllers
{
    public class MoviesController : Controller
{
    public IActionResult Index() //Framsidan för filmer, visar alla filmer i databasen
    {
        return View(FakeDatabase.Movies);
    }

    public IActionResult Details(int id) //Visar detaljer för en specifik film baserat på dess ID
    {
        var movie = FakeDatabase.Movies.FirstOrDefault(m => m.MovieID == id);

        return View(movie);
    }

    public IActionResult Create() 
    {
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
