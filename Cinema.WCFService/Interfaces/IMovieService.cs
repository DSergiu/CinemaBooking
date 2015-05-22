namespace Cinema.WCFService.Interfaces
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Collections.Generic;  

    using Models;
    using Domain;
    using Attributes;      

    [ServiceContract]
    public interface IMovieService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "movie")]
        int CreateMovie(Movie movie);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "movie/{movieId}")]
        void UpdateMovie(Movie movie, string movieId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "movie/{movieId}")]
        void DeleteMovie(string movieId);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "movie/{movieId}")]
        Movie GetMovie(string movieId);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "movies/{page}/{noperpage}")]
        ICollection<Movie> GetMoviePerPage(string page, string noperpage);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "movies/title/{movieTitle}")]
        ICollection<Movie> GetMoviesByTitle(string movieTitle);
    }
}