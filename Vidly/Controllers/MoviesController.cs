using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek"};

        //    //ViewData["Movie"] = movie;
        //    //ViewBag.Movie = movie;

        //    var customerList = new List<Customer> {
        //           new Customer { Id = 1, Name="Dhaval"},
        //           new Customer { Id = 2, Name="Krish"},
        //           new Customer { Id = 3, Name="Mitul"},
        //           new Customer { Id = 4, Name="Saanvi"},
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        vmCustomers = customerList,
        //        vmMovie = movie
        //    };

        //    return View(viewModel);
        //    //return RedirectToAction("Index","Home" , new { page=1, sortby="Name"});
        //}

        //public ActionResult Edit(int id) {

        //    return Content("id:" + id);
        //}

        ApplicationDbContext _context;
        IEnumerable<Movie> movies;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult Index()
        {
            movies = GetMovies();
            return View(movies);
        }
        
        private IEnumerable<Movie> GetMovies() {
            return _context.Movies.ToList();
        }

        ////[Route("movies/released/{year:regex(\\d{4}):range(2011,2015)}/{month:regex(\\d{2})}")]
        //[Route("movies/released/{year:regex(\\d{4}):range(2011,2015)}/{month:regex(\\d{2})}")]
        //public ActionResult ByReleasedDate(int year, int month) {


        //    return Content("Year: " + year + " Month: " + month);
        //}
        
    }
}