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

    public partial class CinemaService : ITicketService
    {
        private ITicketCtrl _ticketCtrl;
        private ITicketCtrl TicketCtrl
        {
            get {
                _ticketCtrl = _ticketCtrl ?? new TicketCtrl();

                return _ticketCtrl;
            }
        }


        public Ticket GetTicket(string ticketId)
        {
            try
            {
                return TicketCtrl.GetTicket(ticketId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
