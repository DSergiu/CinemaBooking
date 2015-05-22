namespace Cinema.WCFService.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    using Domain;
    using Cinema.Controller.Interfaces;
    using Cinema.Controller.Classes;

    using System.ServiceModel.Web;
    using System.Web.Mvc;
    using System.Data.Entity.Validation;
    using Models;

    using AutoMapper;

    public partial class CinemaService : IMovieService
    {
        private IMovieCtrl _movieCtrl;
        private IMovieCtrl MovieCtrl
        {
            get {
                _movieCtrl = _movieCtrl ?? new MovieCtrl();

                return _movieCtrl;
            }
        }

        public int CreateMovie(Movie movie)
        {
            Validation.Validate(movie);

            try
            {
               return MovieCtrl.CreateMovie(movie);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateMovie(Movie movie, string movieId)
        {
            Validation.Validate(movie);

            try
            {
                MovieCtrl.UpdateMovie(movie, movieId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteMovie(string movieId)
        {
            try
            {
                MovieCtrl.DeleteMovie(movieId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public Movie GetMovie(string movieId)
        {
            try
            {
                return MovieCtrl.GetMovie(movieId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Movie> GetMoviePerPage(string page, string noperpage)
        {
            try
            {
                return MovieCtrl.GetMoviesByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }


        public ICollection<Movie> GetMoviesByTitle(string movieTitle)
        {
            try
            {
                return MovieCtrl.GetMoviesByName(movieTitle);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
