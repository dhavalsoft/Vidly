using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;
        IEnumerable<Movie> movies;

        #region "Page Events"

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #endregion
                
        #region "Private Methods"
        private IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(m => m.Genre).ToList();
        }

        #endregion

        #region "Actions"

        public ActionResult Index()
        {
            movies = GetMovies();

            return View(movies);
        }

        public ActionResult New()
        {
            MovieFormViewModel viewModel = new MovieFormViewModel {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);

        }


        public ActionResult Edit(int movieId)
        {
            Movie movie = _context.Movies.Single(m => m.Id == movieId);
            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == null)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
            }
            else
            {
                Movie movieToBeUpdated = _context.Movies.Single(m => m.Id == movie.Id);
                if (movieToBeUpdated != null)
                {
                    movieToBeUpdated.Name = movie.Name;
                    movieToBeUpdated.Director = movie.Director;
                    movieToBeUpdated.ReleasedDate = movie.ReleasedDate;
                    movieToBeUpdated.NoOfDVDs = movie.NoOfDVDs;
                    movieToBeUpdated.GenreId = movie.GenreId;

                    _context.SaveChanges();
                }
            }
            
            return RedirectToAction("Index", "Movies");
        }
        #endregion

    }
}