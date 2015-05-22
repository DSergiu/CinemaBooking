namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IMovieInfoCtrl
    {
        MovieInfo GetMovieInfo(string movieinfoId);
        ICollection<MovieInfo> GetMoviesByTitle(string movieTitle);
        ICollection<MovieInfo> GetMoviesByPage(string page, string noPerPage);

        int CreateMovieInfo(MovieInfo movieinfo);
        void UpdateMovieInfo(MovieInfo movieinfo, string movieinfoId);
        void DeleteMovieInfo(string movieinfoId);
    }
}
