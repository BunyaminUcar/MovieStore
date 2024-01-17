using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        //localhost:42851/movies
        public IActionResult Index()
        {
            return View();
        }
        //localhost:42851/movies/list
        //localhost:42851/movies/list/?
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
    }
}
