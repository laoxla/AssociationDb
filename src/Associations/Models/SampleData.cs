using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Associations.Models
{
    public class SampleData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            if (!db.Categories.Any())
            {
                db.Categories.AddRange(
                    new Category
                    {
                        Name = "Action",
                        Movies = new List<Movie>
                        {
                            new Movie {Title = "Mad Max: Fury Road", Director = "George Miller"},
                            new Movie {Title = "Gods of Egypt", Director = "Alex Proyas"}
                        }
                    },
                    new Category
                    {
                        Name = "Aventures",
                        Movies = new List<Movie>
                        {
                            new Movie {Title = "Hollywood Adventures", Director = "Timothy Kendall"},
                            new Movie {Title = "Everest", Director = "Baltasar Kormakur"},
                            new Movie {Title = "The Revenant", Director = "Alejandro Gonzalez Inarritu"}

                        }
                    }
                    );
                db.SaveChanges();
            }
        }
    }
}
