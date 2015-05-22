namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class BookingCtrl : IBookingCtrl
    {
        private static Object lockobj = new Object();

        public int CreateBooking(Booking booking)
        {
            if(booking.Tickets.Count == 0)
                throw new ArgumentException("No seats booked. Please add at least 1 seat");


            System.Diagnostics.Debug.WriteLine("Enter in method: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

            
            using (var uow = new EFUnitOfWork())
            {
                User user = uow.UserRepository.GetByID(booking.UserGuid);
                if (user == null)
                    throw new ArgumentException("Invalid user id.");

                user = uow.UserRepository.GetByID(booking.CreatedBy);
                if (user == null)
                    throw new ArgumentException("Invalid CreatedBy id.");

                Screening screening = uow.ScreeningRepository.GetScreening(booking.ScreeningId);
                if (screening == null)
                    throw new ArgumentException("Invalid screening id.");
                
                var ticketTypes = uow.TicketTypeRepository.GetAllTicketTypes().ToArray();


                lock (lockobj)
                {
                    //System.Diagnostics.Debug.WriteLine("Enter Lock: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

                    foreach (var ticket in booking.Tickets)
                    {
                        TicketType ticketType = ticketTypes.FirstOrDefault(t => t.TicketTypeId.Equals(ticket.TicketTypeId));
                        if (ticketType == null)
                            throw new ArgumentException("Invalid ticket type.");

                        Seat seat = uow.SeatRepository.GetSeat(screening.ScreeningInfo.HallId, ticket.Row, ticket.Column);
                        if (seat == null)
                            throw new ArgumentException(String.Format("The seat on row {0} and column {1} does not exist in hall {2}.", ticket.Row, ticket.Column, screening.ScreeningInfo.Hall.HallName));

                        bool isAvalable = uow.TicketRepository.IsAvailable(screening.ScreeningId, ticket);

                        if (!isAvalable)
                            throw new ArgumentException(String.Format("The seat on row {0} and column {1} was already booked. Choose another seat.", ticket.Row, ticket.Column));

                        booking.TotalPrice += screening.ScreeningInfo.TicketPrice * (1 - ticketType.Discount / 100);
                    }

                    // Everything is fine, just insert the booking in the database
                    uow.BookingRepository.CreateBooking(booking);
                    uow.Save();
                    //System.Diagnostics.Debug.WriteLine("Exit Lock: " + System.Threading.Thread.CurrentThread.ManagedThreadId);

                    return booking.BookingId;                    
                }
            }
        }


        public Booking GetBookingById(string bookingId)
        {
            int bookingIdInt;

            try
            {
                bookingIdInt = Int32.Parse(bookingId);
            }
            catch {
                throw new ArgumentException("Booking Id must be a number");
            }


            using (var uow = new EFUnitOfWork())
            {
                Booking booking = uow.BookingRepository.GetBooking(bookingIdInt);
                return booking;
            }
            
        }

        public ICollection<Booking> GetBookingsByScreeningId(string sreeningId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(sreeningId);
            }
            catch
            {
                throw new ArgumentException("Screening Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.BookingRepository.GetBookingsByScreeningId(screeningIdInt).ToArray();
            }
        }

        public ICollection<Booking> GetBookingsByUserGuid(string userGuid)
        {
            Guid userGuidGuid;

            try
            {
                userGuidGuid = new Guid(userGuid);
            }
            catch
            {
                throw new ArgumentException("Invalid user id.");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.BookingRepository.GetBookingsByUserGuid(userGuidGuid).ToArray();
            }

        }

        public ICollection<Booking> GetBookingsByPhoneNo(string phoneNo)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.BookingRepository.GetBookingsByPhoneNo(phoneNo).ToArray();
            }
        }

        public ICollection<Booking> GetAllBookingsByPage(string page, string noPerPage)
        {
            int pageInt, noPerPageInt;
            try
            {
                pageInt = Int32.Parse(page);
                noPerPageInt = Int32.Parse(noPerPage);
            }
            catch
            {
                throw new ArgumentException("Page and number per page must be numeric values");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.BookingRepository.GetAllBookingsByPage(pageInt, noPerPageInt).ToArray();
            }
        }


        public void DeleteBooking(string bookingId)
        {
            int bookingIdInt;

            try
            {
                bookingIdInt = Int32.Parse(bookingId);
            }
            catch
            {
                throw new ArgumentException("Booking Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                Booking booking = uow.BookingRepository.GetBooking(bookingIdInt);
                if (booking != null)
                {
                    booking.IsCanceled = true;
                    uow.BookingRepository.Update(booking);
                    uow.Save();
                }                
            }
        }
    }
}
