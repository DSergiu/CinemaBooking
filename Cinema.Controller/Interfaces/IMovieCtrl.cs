namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IMovieCtrl
    {
        Movie GetMovie(string movieId);
        ICollection<Movie> GetMoviesByName(string movieName);
        ICollection<Movie> GetMoviesByPage(string page, string noPerPage);

        int CreateMovie(Movie movie);
        void UpdateMovie(Movie movie, string movieId);
        void DeleteMovie(string movieId);
    }
}
