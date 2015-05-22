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
    public interface ITicketTypeService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "tickettype/{tickettypeId}")]
        TicketType GetTicketType(string tickettypeId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "tickettype/type/{ticketType}")]
        TicketType GetTicketTypeByType(string ticketType);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "tickettypes")]
        ICollection<TicketType> GetAllTicketTypes();

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "tickettype")]
        int CreateTicketType(TicketType tickettype);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "tickettype/{tickettypeId}")]
        void UpdateTicketType(TicketType tickettype, string tickettypeId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "tickettype/{tickettypeId}")]
        void DeleteTicketType(string tickettypeId);
    }
}