namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class MovieInfoRepoExtensions
    {
        public static MovieInfo GetMovieInfoById(this IGenericRepository<MovieInfo> _movieinfoRepo, int movieinfoId)
        {
            return _movieinfoRepo.Find(mi => mi.MovieInfoId.Equals(movieinfoId)).FirstOrDefault();
        }

        public static IQueryable<MovieInfo> GetMovieInfosByTitle(this IGenericRepository<MovieInfo> _movieinfoRepo, string movieName)
        {
            return _movieinfoRepo.Find(mi => mi.Title.Contains(movieName));
        }

        public static IQueryable<MovieInfo> GetMovieInfosByPage(this IGenericRepository<MovieInfo> _movieinfoRepo, int page, int moviesPerPage)
        {
            return _movieinfoRepo.Find(m => true).OrderBy(m => m.MovieInfoId).Skip(page * (moviesPerPage - 1)).Take(moviesPerPage);
        }

    }
}
