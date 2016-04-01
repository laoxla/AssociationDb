using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Associations.Models;
using Microsoft.Data.Entity;
using Associations.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Associations.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // q  = _db.Movies.Where(m => m.Category.Name == "Action")
            //var q = _db.Movies.Where(m => m.Category.Name == "Action");
            //if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            //{
            //    q = q.Where(m => m.Title == "Gods of Egypt");
            //}
            //var movies = q.ToList();

            //var movies = _db.Movies.Select(m => new 
            //{
            //    CategoryName = m.Category.Name,
            //    Director = m.Director,
            //    MovieId = m.Id,
            //    Title = m.Title
            //}).ToList();
            //return Ok(movies);
            var movies = _db.Categories.Select(c => new { c.Name, movies = c.Movies.Select(m => m.Title) });
            return Ok(movies);
        }
    }
}
