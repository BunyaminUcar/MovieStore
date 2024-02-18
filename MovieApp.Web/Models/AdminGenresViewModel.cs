using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Models
{
    public class AdminGenresViewModel
    {
        [Required(ErrorMessage = "Entering genre information is required!")]
        [StringLength(25, MinimumLength = 3,ErrorMessage = "Type information must be between 3 and 25 characters")]
        public string Name { get; set; }
        public List<AdminGenreViewModel> Genres { get; set; }
    }

    public class AdminGenreViewModel
    {
        public int GenreId { get; set; }

        public string Name { get; set; }

        public int Count { get; set;}

    }

    public class AdminGenreEditViewModel
    {
        public int GenreId { get; set; }
        [Required(ErrorMessage = "Entering genre information is required!")]
        public string Name { get; set; }
        public List<AdminMoviesViewModel.AdminMovieViewModel> Movies { get; set; }
    }
}
