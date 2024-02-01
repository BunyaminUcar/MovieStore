using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Models
{
    public class AdminMoviesViewModel
    {
        public List<AdminMovieViewModel> Movies
        {
            get; set;

        }

        public class AdminMovieViewModel
        {
            public int MovieId { get; set; }
            public string Title { get; set; }
            public string ImageURL { get; set; }
            public List<Genre> Genres { get; set; }
        }
        public class AdminCreateMovieModel
        {
            [DisplayName("Film Adı")]
            [Required(ErrorMessage = "Film adı gereklidir")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Film adı 3 ila 50 karekter uzunluğuna olmalıdır")]
            public string Title { get; set; }
            [DisplayName("Açıklama")]
            [Required(ErrorMessage = "Film açıklaması gereklidir")]
            public string Description { get; set; }
            [DisplayName("Türü")]
            [Required(ErrorMessage = "Tür seçimi zorunludur")]
            public int[] GenreIds { get; set; }
        }
        public class AdminEditMovieViewModel
        {
            public int MovieId { get; set; }
            [DisplayName("Film Adı")]
            [Required(ErrorMessage = "Film adı gereklidir")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Film adı 3 ila 50 karekter uzunluğuna olmalıdır")]
            public string Title { get; set; }
            [DisplayName("Açıklama")]
            [Required(ErrorMessage = "Film açıklaması gereklidir")]
            public string Description { get; set; }
            public string ImageURL { get; set; }
            [Required(ErrorMessage = "Tür seçimi zorunludur")]
            public int[] GenreIds { get; set; }

        }

    }
}
