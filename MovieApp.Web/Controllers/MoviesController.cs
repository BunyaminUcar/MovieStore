using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Web.Entity;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Web.Controllers
{
    
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {

            return View(_context.Movies.Find(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();

        }
        //localhost:42851/movies
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        //localhost:42851/movies/list
        //localhost:42851/movies/list/?
        [HttpGet]
        public IActionResult List(int? id, string q)

        {

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();

            if (id != null)
            {
                movies = movies
                    .Include(m => m.Genres)
                    .Where(m => m.Genres.Any(g => g.GenreId == id));
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i =>
                    i.Title.ToLower().Contains(q.ToLower()) ||
                    i.Description.ToLower().Contains(q.ToLower()));
            }

            var model = new MoviesViewModel()
            {

                Movies = movies.ToList()

            };

            return View("Movies", model);
        }


    }
}
