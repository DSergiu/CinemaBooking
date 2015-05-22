namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class MovieInfoCtrl : IMovieInfoCtrl
    {
        public MovieInfo GetMovieInfo(string movieinfoId)
        {
            int movieIdInt;
            try
            {
                movieIdInt = Int32.Parse(movieinfoId);
            }
            catch
            {
                throw new ArgumentException("Movie Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.MovieInfoRepository.GetMovieInfoById(movieIdInt);
            }
        }

        public ICollection<MovieInfo> GetMoviesByTitle(string movieTitle)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.MovieInfoRepository.GetMovieInfosByTitle(movieTitle).ToArray();
            }
        }


        public ICollection<MovieInfo> GetMoviesByPage(string page, string noPerPage)
        {
            int pageInt, noPerPageInt;
            try
            {
                pageInt = Int32.Parse(page);
                noPerPageInt = Int32.Parse(noPerPage);
            }
            catch
            {
                throw new ArgumentException("Page and number per page must be numeric values");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.MovieInfoRepository.GetMovieInfosByPage(pageInt, noPerPageInt).ToArray();
            }
        }




        public int CreateMovieInfo(MovieInfo movieinfo)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.MovieInfoRepository.Insert(movieinfo);
                uow.Save();

                return movieinfo.MovieInfoId;
            }
        }

        public void UpdateMovieInfo(MovieInfo movieinfo, string movieinfoId)
        {
            int movieinfoIdInt;
            try
            {
                movieinfoIdInt = Int32.Parse(movieinfoId);
            }
            catch
            {
                throw new ArgumentException("MovieInfo Id must be a number");
            }

            movieinfo.MovieInfoId = movieinfoIdInt;

            using (var uow = new EFUnitOfWork())
            {
                uow.MovieInfoRepository.Update(movieinfo);
                uow.Save();
            }
        }

        public void DeleteMovieInfo(string movieinfoId)
        {
            int movieinfoIdInt;
            try
            {
                movieinfoIdInt = Int32.Parse(movieinfoId);
            }
            catch
            {
                throw new ArgumentException("MovieInfo Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.MovieInfoRepository.DeleteById(movieinfoIdInt);
                uow.Save();
            }
        }
    }
}
