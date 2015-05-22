namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface ITicketTypeCtrl
    {
        TicketType GetTicketType(string tickettypeId);
        TicketType GetTicketTypeByType(string ticketType);
        ICollection<TicketType> GetAllTicketTypes();

        int CreateTicketType(TicketType ticketType);
        void UpdateTicketType(TicketType ticketType, string tickettypeId);
        void DeleteTicketType(string tickettypeId);
    }
}
