using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using static MovieApp.Web.Models.AdminMoviesViewModel;



namespace MovieApp.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly MovieContext _context;

        public AdminController(MovieContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _context.Movies.Select(m => new AdminEditMovieViewModel
            {
                MovieId = m.MovieId,
                Title = m.Title,
                Description = m.Description,
                ImageURL = m.ImageURL,
                SelectedGenres=m.Genres
            }).FirstOrDefault(m => m.MovieId == id);

            ViewBag.Genres = _context.Genres.ToList();

            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }
        [HttpPost]
        public IActionResult MovieUpdate(AdminEditMovieViewModel model)
        {
            var entity = _context.Movies.Find(model.MovieId);
            if (entity == null)
            {
                return NotFound();

            }
            entity.Title= model.Title;
            entity.Description = model.Description;
            entity.ImageURL = model.ImageURL;

            _context.SaveChanges();
            return RedirectToAction("MovieList");

        }


        public IActionResult MovieList()
        {
            return View(new AdminMoviesViewModel
                {
                Movies = _context.Movies
                    .Include(m => m.Genres)
                    .Select(m => new AdminMovieViewModel
                    {
                        MovieId = m.MovieId,
                        Title = m.Title,
                        ImageURL = m.ImageURL,
                        Genres = m.Genres.ToList()
                    })
                    .ToList()
            });

        }
    }
}
