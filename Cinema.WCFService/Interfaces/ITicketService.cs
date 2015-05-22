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
    public interface ITicketService
    {
        [Authentication]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "ticket/{ticketId}")]
        Ticket GetTicket(string ticketId);
    }
}