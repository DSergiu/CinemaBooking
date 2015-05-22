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
    public interface IBookingService
    {
        [Authentication]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "booking")]
        int CreateBooking(BookingModel model);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "booking/{bookingId}")]
        void DeleteBooking(string bookingId);

        [Authentication]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "booking/{bookingId}")]
        Booking GetBooking(string bookingId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "bookings/phone/{phone}")]
        ICollection<Booking> GetBookingsByPhone(string phone);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "bookings/screening/{screeningId}")]
        ICollection<Booking> GetBookingsByScreeningId(string screeningId);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "bookings/page/{page}/{noperpage}")]
        ICollection<Booking> GetAllBookingsByPage(string page, string noperpage);
    }
}
