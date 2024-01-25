using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        //localhost:42851/movies
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        //localhost:42851/movies/list
        //localhost:42851/movies/list/?
        [HttpGet]
        public IActionResult List(int? id,string q)

        {

            //var kelime = HttpContext.Request.Query["q"].ToString();

            var movies = MovieRepository.Movies;

            if (id!=null)
            {
                movies = movies.Where(m => m.GenreId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => 
                    i.Title.ToLower().Contains(q.ToLower()) || 
                    i.Description.ToLower().Contains(q.ToLower())).ToList();
            }

            var model = new MoviesViewModel()
            {

                Movies = movies

            };

            return View("Movies",model);
        }
        //localhost:42851/movies/details/?
        public IActionResult Details(int id) {

            return View(MovieRepository.GetById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();

        }
        [HttpPost]
        public IActionResult Create(Movie m)
        {

            if (ModelState.IsValid)
            {
                MovieRepository.Add(m);
                TempData["Message"] = $"{m.Title} isimli film eklendi";

                return RedirectToAction("List");

            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");

            return View();

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {   //Selected list öğeleri gönderiliyor
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(MovieRepository.GetById(id));

        }


        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(m);
                
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });


            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(m);

        }

        [HttpPost]
        public IActionResult Delete(int MovieId, string Title)
        {
            MovieRepository.Delete(MovieId);
            TempData["Message"] = $"{Title} isimli film silindi";
            return RedirectToAction("List");

        }

    }
}
