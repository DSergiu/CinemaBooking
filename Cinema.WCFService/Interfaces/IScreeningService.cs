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
    public interface IScreeningService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "screening")]
        int CreateScreening(Screening screening);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "screening/{screeningId}")]
        void UpdateScreening(Screening screening, string screeningId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "screening/{screeningId}")]
        void DeleteScreening(string screeningId);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "screening/{screeningId}")]
        Screening GetScreening(string screeningId);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "screenings/{page}/{noperpage}")]
        ICollection<Screening> GetScreeningsPerPage(string page, string noperpage);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebGet(UriTemplate = "screening/{screeningId}/{noOfTickets}")]
        ICollection<Seat> GetSeatsSuggestion(string screeningId, string noOfTickets);
    }
}