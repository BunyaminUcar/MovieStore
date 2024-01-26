using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieApp.Web.Entity
{
    public class Movie
    {

        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Players { get; set; }
        public string ImageURL { get; set; }
        [Required]
        public int? GenreId { get; set; }

    }
}
