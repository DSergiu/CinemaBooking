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

    public partial class CinemaService : IMovieInfoService
    {
        private IMovieInfoCtrl _movieInfoCtrl;
        private IMovieInfoCtrl MovieInfoCtrl
        {
            get {
                _movieInfoCtrl = _movieInfoCtrl ?? new MovieInfoCtrl();

                return _movieInfoCtrl;
            }
        }

        public int CreateMovieInfo(MovieInfo movieinfo)
        {
            Validation.Validate(movieinfo);

            try
            {
                return MovieInfoCtrl.CreateMovieInfo(movieinfo);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
        
        public void UpdateMovieInfo(MovieInfo movieinfo, string movieinfoId)
        {
            Validation.Validate(movieinfo);

            try
            {
                MovieInfoCtrl.UpdateMovieInfo(movieinfo, movieinfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteMovieInfo(string movieinfoId)
        {
            try
            {
                MovieInfoCtrl.DeleteMovieInfo(movieinfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public MovieInfo GetMovieInfo(string movieinfoId)
        {
            try
            {
                return MovieInfoCtrl.GetMovieInfo(movieinfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<MovieInfo> GetMovieInfosPerPage(string page, string noperpage)
        {
            try
            {
                return MovieInfoCtrl.GetMoviesByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
