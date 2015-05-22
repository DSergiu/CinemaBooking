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
    public interface IHallService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "hall")]
        int CreateHall(Hall hall);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "hall/{hallId}")]
        void UpdateHall(Hall hall, string hallId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "hall/{hallId}")]
        void DeleteHall(string hallId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "hall/{hallId}")]
        Hall GetHall(string hallId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "hall/name/{hallName}")]
        Hall GetHallByName(string hallName);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "halls")]
        ICollection<Hall> GetAllHalls();
    }
}