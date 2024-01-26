﻿using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies =null;

        static MovieRepository()
        {

            _movies = new List<Movie>() 
            
            {

                new Movie {
                    MovieId=1,
                    Title="Jiu Jitsu",
                    Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ali",
                    Director="Dimitri Logothetis",
                    Players=new string[] { "Nicolas Cage", "Alain Moussi"},
                    ImageURL= "vikings.jpg",
                GenreId = 1
                },
                new Movie {
                MovieId = 2,
                Title="Fatman",
                Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a negl", 
                Director="Eshom Nelms",
                Players=new string[] { "Mel Gibson", "Walton Goggins", "Michelle Lan"},
                ImageURL="reacher.jpg",
                GenreId = 1
                },
                new Movie {
                MovieId = 3,
                Title="The Dalton Gang",
                Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton",
                Director="Christopher Forbes",
                Players=new string[] { "oyuncu 1", "oyuncu 2"},
                ImageURL="vikings.jpg",
                GenreId = 3
                },

                new Movie {
                MovieId=4,
                Title="Tenet",
                Description="Armed with only one word Tenet and fighting for the survival of the entire world, the Protagonis",
                Director="Christopher Nolan",
                Players=new string[] { "Robert Pattinson", "Elizabeth Debicki"},
                ImageURL="the boys.jpg",
                GenreId = 3
                },
                new Movie {
                MovieId = 5,
                Title="The Craft: Legacy",
                Description="An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into",
                Director="Zoe Lister-Jones",
                Players=new string[] { "Cailee Spaeny", "Zoey Luna"},
                ImageURL="reacher.jpg",
                GenreId = 4
                },
                new Movie {
                MovieId = 6,
                Title="Hard Kill",
                Description="The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries",
                Director="Matt Eskandari",
                Players=new string[] { "Bruce Willis", "Jesse Metcalfe"},
                ImageURL="vikings.jpg",
                GenreId = 3
                }

            };
        }

        public static List<Movie> Movies {  get { return _movies; } }

        public static void Add(Movie movie)
        {
            movie.MovieId = Movies.Count() + 1;
            _movies.Add(movie);

        }

        public static Movie GetById(int id) { 
           
        return _movies.FirstOrDefault(m => m.MovieId == id);}

        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImageURL=m.ImageURL;
                    movie.GenreId= m.GenreId;
                    break;
                }
            }
        }

        public static void Delete(int MovieId)
        {
            var movie = GetById(MovieId);
            if (movie!=null)
            {
                _movies.Remove(movie);
            }
        }
    }
}
