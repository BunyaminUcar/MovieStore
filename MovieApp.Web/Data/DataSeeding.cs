using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();

            context.Database.Migrate();

            var genres = new List<Genre>()
            {


                new Genre
                {
                    Name = "Macera", Movies=new List<Movie>()

                    

                },
                new Genre { Name = "Komedi" },
                new Genre { Name = "Bilim Kurgu" },
                new Genre { Name = "Drama" },
                new Genre { Name = "Savaş" }


            };
            var movies = new List<Movie>()

            {
                new Movie
                {
                    Title = "Jiu Jitsu",
                    Description =
                        "Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of ali",
                    ImageURL = "vikings.jpg",
                    Genres= new List<Genre>(){genres[0],  genres[2] }
                },
                new Movie
                {
                    Title = "Fatman",
                    Description =
                        "A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a negl",
                    ImageURL = "reacher.jpg",
                    Genres= new List<Genre>(){genres[1], genres[2] }
                },
                new Movie
                {
                    Title = "The Dalton Gang",
                    Description =
                        "When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton",
                    ImageURL = "vikings.jpg",
                    Genres= new List < Genre >() { genres[2], genres[3] }
                },

                new Movie
                {
                    Title = "Tenet",
                    Description =
                        "Armed with only one word Tenet and fighting for the survival of the entire world, the Protagonis",
                    ImageURL = "the boys.jpg",
                    Genres= new List < Genre >() { genres[2], genres[2] }
                },
                new Movie
                {
                    Title = "The Craft: Legacy",
                    Description =
                        "An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into",
                    ImageURL = "reacher.jpg",
                    Genres= new List < Genre >() { genres[4],  genres[2] }
                },
                new Movie
                {
                    Title = "Hard Kill",
                    Description =
                        "The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries",
                    ImageURL = "vikings.jpg",
                    Genres= new List<Genre>(){genres[2], genres[4] }
                }

            };
            var users = new List<User>() {
                new User() { Username="usera", Email="usera@gmail.com", Password="1234"},
                new User() { Username="userb", Email="userb@gmail.com", Password="1234"},
                new User() { Username="userc", Email="userc@gmail.com",Password="1234"},
                new User() { Username="userb", Email="userb@gmail.com",Password="1234"}
            };
            var people = new List<Person>()
            {
                new Person()
                {
                Name="Personel 1",
                Biography="tanıtım 1",
                User=users[0]


                },
                new Person()
                {
                    Name="Personel 2",
                    Biography="tanıtım 2",
                    User=users[0]


                }

            };
            var crews = new List<Crew>()
            {
                new Crew(){Movie=movies[0],Person=people[0],Job="Yönetmen"},
                new Crew(){Movie=movies[0],Person=people[1],Job="Yönetmen Yard."},
            };
            var casts = new List<Cast>()
            {
                new Cast() { Movie = movies[0], Person = people[0] ,Name="Oyuncu Adı1",Character = "Karekter1"},
                new Cast() { Movie = movies[0], Person = people[1] ,Name="Oyuncu Adı2",Character = "Karekter2"}
            };

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);
                }

                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(users);
                }

                if (context.People.Count() == 0)
                {
                    context.People.AddRange(people);
                }

                if (context.Casts.Count() == 0)
                {
                    context.Casts.AddRange(casts);
                }

                if (context.Crews.Count() == 0)
                {
                    context.Crews.AddRange(crews);
                }


                context.SaveChanges();
            }
        }
    }
}
