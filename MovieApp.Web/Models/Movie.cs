using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Film Başlığı boş geçilemez")]
        [StringLength(50,MinimumLength = 5)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Film Açıklaması boş geçilemez")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public int? GenreId { get; set; } 

    }
}
