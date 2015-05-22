namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class TicketTypeRepoExtensions
    {
        public static Ticket GetTicket(this IGenericRepository<Ticket> _ticketRepo, int ticketId)
        {
            return _ticketRepo.Find(t => t.TicketId.Equals(ticketId)).FirstOrDefault();
        }

        public static bool IsAvailable(this IGenericRepository<Ticket> _ticketRepo, int screeningId, Ticket ticket)
        {
            return null == _ticketRepo.Find(t => t.Booking.IsCanceled==false && t.Booking.ScreeningId.Equals(screeningId) && t.Row.Equals(ticket.Row) && t.Column.Equals(ticket.Column)).FirstOrDefault();
        }

        public static IQueryable<Ticket> GetTicketsByBookingId(this IGenericRepository<Ticket> _ticketRepo, int bookingId)
        {
            return _ticketRepo.Find(t => t.BookingId.Equals(bookingId));
        }
    }
}
