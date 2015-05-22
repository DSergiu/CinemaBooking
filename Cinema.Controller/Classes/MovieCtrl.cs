namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class MovieCtrl : IMovieCtrl
    {
        public Movie GetMovie(string movieId)
        {
            int movieIdInt;
            try
            {
                movieIdInt = Int32.Parse(movieId);
            }
            catch
            {
                throw new ArgumentException("Movie Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.MovieRepository.GetMovieById(movieIdInt);
            }
        }

        public ICollection<Movie> GetMoviesByName(string movieName)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.MovieRepository.GetMoviesByName(movieName).ToArray();
            }
        }

        public ICollection<Movie> GetMoviesByPage(string page, string noPerPage)
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
                return uow.MovieRepository.GetMoviesByPage(pageInt, noPerPageInt).ToArray();
            }
        }

        public int CreateMovie(Movie movie)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.MovieRepository.Insert(movie);
                uow.Save();

                return movie.MovieId;
            }
        }

        public void UpdateMovie(Movie movie, string movieId)
        {
            int movieIdInt;
            try
            {
                movieIdInt = Int32.Parse(movieId);
            }
            catch
            {
                throw new ArgumentException("Movie Id must be a number");
            }

            movie.MovieId = movieIdInt;

            using (var uow = new EFUnitOfWork())
            {
                MovieInfo movieInfo = uow.MovieInfoRepository.GetMovieInfoById(movie.MovieInfoId);

                if (movieInfo == null)
                {
                    throw new ArgumentException("Invalid Movie Info Id.");
                }

                uow.MovieRepository.Update(movie);
                uow.Save();
            }
        }

        public void DeleteMovie(string movieId)
        {
            int movieIdInt;
            try
            {
                movieIdInt = Int32.Parse(movieId);
            }
            catch
            {
                throw new ArgumentException("Movie Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.MovieRepository.DeleteById(movieIdInt);
                uow.Save();
            }
        }
    }
}
