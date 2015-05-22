namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class TicketTypeCtrl : ITicketTypeCtrl
    {
        public TicketType GetTicketType(string tickettypeId)
        {
            int tickettypeIdInt;
            try
            {
                tickettypeIdInt = Int32.Parse(tickettypeId);
            }
            catch
            {
                throw new ArgumentException("Ticket Type Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.TicketTypeRepository.GetTicketType(tickettypeIdInt);
            }
        }

        public TicketType GetTicketTypeByType(string ticketType)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.TicketTypeRepository.GetTicketTypeByType(ticketType);
            }
        }

        public ICollection<TicketType> GetAllTicketTypes()
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.TicketTypeRepository.GetAllTicketTypes().ToArray();
            }
        }

        public int CreateTicketType(TicketType ticketType)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.TicketTypeRepository.Insert(ticketType);
                uow.Save();

                return ticketType.TicketTypeId;
            }
        }

        public void UpdateTicketType(TicketType ticketType, string tickettypeId)
        {
            int tickettypeIdInt;
            try
            {
                tickettypeIdInt = Int32.Parse(tickettypeId);
            }
            catch
            {
                throw new ArgumentException("Ticket Type Id must be a number");
            }

            ticketType.TicketTypeId = tickettypeIdInt;

            using (var uow = new EFUnitOfWork())
            {
                uow.TicketTypeRepository.Update(ticketType);
                uow.Save();
            }
        }

        public void DeleteTicketType(string tickettypeId)
        {
            int tickettypeIdInt;
            try
            {
                tickettypeIdInt = Int32.Parse(tickettypeId);
            }
            catch
            {
                throw new ArgumentException("Ticket Type Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.TicketTypeRepository.DeleteById(tickettypeId);
                uow.Save();
            }
        }
    }
}
