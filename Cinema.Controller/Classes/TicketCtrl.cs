namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class TicketCtrl : ITicketCtrl
    {
        public Ticket GetTicket(string ticketId)
        {
            int  ticketIdInt;
            try
            {
                ticketIdInt = Int32.Parse(ticketId);
            }
            catch
            {
                throw new ArgumentException("Ticket Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.TicketRepository.GetTicket(ticketIdInt);
            }
        }

        public ICollection<Ticket> GetTicketsByBookingId(string bookingId)
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
                return uow.TicketRepository.GetTicketsByBookingId(bookingIdInt).ToArray();
            }
        }
    }
}
