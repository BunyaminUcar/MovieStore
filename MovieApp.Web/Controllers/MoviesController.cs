using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        //localhost:42851/movies
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult List()
        {
            var filmlistesi = new List<Movie>() 
            {
                new Movie {Title="film1",
                Description="açıklama 1",
                Director="Yönetmen 1",
                Players=new string[] {"oyuncu 1","oyuncu 2"},
                ImageURL="the boys.jpg"
                },
                new Movie {Title="film2",
                Description="açıklama 2",
                Director="Yönetmen 2",
                Players=new string[] {"oyuncu 3","oyuncu 4"},
                ImageURL="reacher.jpg"
                },
                new Movie {Title="film3",
                Description="açıklama 3",
                Director="Yönetmen 3",
                Players=new string[] {"oyuncu 5","oyuncu 6"},
                ImageURL="vikings.jpg"
                }



            };

            

            var model = new MovieGenreViewModel()
            {
                Movies = filmlistesi
               

            };

            return View("Movies",model);
        }
        //localhost:42851/movies/details
        public string Details() {

            return "Film Detayı";
        }
    }
}
