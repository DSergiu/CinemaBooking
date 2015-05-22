namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class TicketRepoExtensions
    {
        public static TicketType GetTicketType(this IGenericRepository<TicketType> _tickettypeRepo, int ticketTypeId)
        {
            return _tickettypeRepo.Find(t => t.TicketTypeId.Equals(ticketTypeId)).FirstOrDefault();
        }

        public static TicketType GetTicketTypeByType(this IGenericRepository<TicketType> _tickettypeRepo, string ticketType)
        {
            return _tickettypeRepo.Find(t => t.Type.Equals(ticketType)).FirstOrDefault();
        }

        public static IQueryable<TicketType> GetAllTicketTypes(this IGenericRepository<TicketType> _tickettypeRepo)
        {
            return _tickettypeRepo.Find(t => true);
        }
    }
}
