using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        //localhost:42851/movies
        public IActionResult Index()
        {
            return View();
        }
        public string List()
        {
            return "Deneme";
        }
        //localhost:42851/movies/details
        public string Details() {

            return "Film Detayı";
        }
    }
}
