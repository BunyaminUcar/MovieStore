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
            
            };
            var movies = new List<Movie>()

            {

                
            };
            var users = new List<User>() {
                
            };
            var people = new List<Person>()
            {
               

            };
            var crews = new List<Crew>()
            {
               
            };
            var casts = new List<Cast>()
            {
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
