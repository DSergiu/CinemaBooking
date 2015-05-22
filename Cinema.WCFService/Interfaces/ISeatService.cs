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
    public interface ISeatService
    {
        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "seat")]
        void CreateSeat(Seat seat);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "seat")]
        void UpdateSeat(Seat seat);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "seat")]
        void DeleteSeat(Seat seat);
    }
}