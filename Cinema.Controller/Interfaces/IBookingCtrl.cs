namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IBookingCtrl
    {
        Booking GetBookingById(string bookingId);
        ICollection<Booking> GetBookingsByUserGuid(string userGuid);
        ICollection<Booking> GetBookingsByScreeningId(string sreeningId);
        ICollection<Booking> GetBookingsByPhoneNo(string phoneNo);
        ICollection<Booking> GetAllBookingsByPage(string page, string noPerPage);

        int CreateBooking(Booking booking);
        void DeleteBooking(string bookingId);
    }
}
