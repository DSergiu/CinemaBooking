namespace Cinema.WCFService.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    using Domain;
    using Cinema.Controller.Interfaces;
    using Cinema.Controller.Classes;

    using System.ServiceModel.Web;
    using System.Web.Mvc;
    using System.Data.Entity.Validation;
    using Models;

    using AutoMapper;

    public partial class CinemaService : IBookingService
    {
        private IBookingCtrl _bookingCtrl;
        private IBookingCtrl BookingCtrl {
            get {
                _bookingCtrl = _bookingCtrl ?? new BookingCtrl();

                return _bookingCtrl;
            }
        }


        public int CreateBooking(BookingModel model)
        {
            Validation.Validate(model);

            Mapper.CreateMap<BookingModel, Booking>();
            Mapper.CreateMap<TicketModel, Ticket>();
            Booking booking = Mapper.Map<BookingModel, Booking>(model);

            //Set author of the booking
            booking.CreatedBy = Attributes.Identity.User.UserGuid;

            try
            {
                return BookingCtrl.CreateBooking(booking);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void DeleteBooking(string bookingId)
        {
            try
            {
                BookingCtrl.DeleteBooking(bookingId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public Booking GetBooking(string bookingId)
        {
            try
            {
                Booking booking = BookingCtrl.GetBookingById(bookingId);
                return booking;
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Booking> GetBookingsByPhone(string phone)
        {
            try
            {
                return BookingCtrl.GetBookingsByPhoneNo(phone);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Booking> GetBookingsByScreeningId(string screeningId)
        {
            try
            {
                return BookingCtrl.GetBookingsByScreeningId(screeningId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Booking> GetAllBookingsByPage(string page, string noperpage)
        {
            try
            {
                return BookingCtrl.GetAllBookingsByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
