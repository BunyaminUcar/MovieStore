using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieApp.Web.Entity
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public List<Genre> Genres { get; set; }

    }
}
