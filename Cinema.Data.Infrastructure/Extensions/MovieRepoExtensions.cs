namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class MovieRepoExtensions
    {
        public static Movie GetMovieById(this IGenericRepository<Movie> _movieRepo, int movieId)
        {
            return _movieRepo.Find(m => m.MovieId.Equals(movieId), m => m.MovieInfo).FirstOrDefault();
        }

        public static IQueryable<Movie> GetMoviesByName(this IGenericRepository<Movie> _movieRepo, string movieName)
        {
            return _movieRepo.Find(m => m.MovieInfo.Title.Contains(movieName));
        }

        public static IQueryable<Movie> GetMoviesByPage(this IGenericRepository<Movie> _movieRepo, int page, int moviesPerPage)
        {
            return _movieRepo.Find(m => true, m => m.MovieInfo).OrderBy(m => m.MovieId).Skip(page * (moviesPerPage - 1)).Take(moviesPerPage);
        }
    }
}
