namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface ITicketCtrl
    {
        Ticket GetTicket(string ticketId);
        ICollection<Ticket> GetTicketsByBookingId(string bookingId);
    }
}
