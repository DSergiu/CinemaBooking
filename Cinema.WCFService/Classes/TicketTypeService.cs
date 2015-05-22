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

    public partial class CinemaService : ITicketTypeService
    {
        private ITicketTypeCtrl _ticketTypeCtrl;
        private ITicketTypeCtrl TicketTypeCtrl
        {
            get {
                _ticketTypeCtrl = _ticketTypeCtrl ?? new TicketTypeCtrl();

                return _ticketTypeCtrl;
            }
        }

        public TicketType GetTicketType(string tickettypeId)
        {
            try
            {
                return TicketTypeCtrl.GetTicketType(tickettypeId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public TicketType GetTicketTypeByType(string ticketType)
        {
            try
            {
                return TicketTypeCtrl.GetTicketTypeByType(ticketType);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<TicketType> GetAllTicketTypes()
        {
            try
            {
                return TicketTypeCtrl.GetAllTicketTypes();
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public int CreateTicketType(TicketType tickettype)
        {
            Validation.Validate(tickettype);

            try
            {
                return TicketTypeCtrl.CreateTicketType(tickettype);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateTicketType(TicketType tickettype, string tickettypeId)
        {
            try
            {
                TicketTypeCtrl.UpdateTicketType(tickettype, tickettypeId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteTicketType(string tickettypeId)
        {
            try
            {
                TicketTypeCtrl.DeleteTicketType(tickettypeId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }
    }
}
