namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;   

    public static class SeatRepoExtensions
    {
        public static Seat GetSeat(this IGenericRepository<Seat> _seatRepo, int hallId, int row, int column)
        {
            return _seatRepo.Find(s => s.HallId.Equals(hallId) && s.Row.Equals(row) && s.Column.Equals(column)).FirstOrDefault();
        }

        public static IQueryable<Seat> GetSeatsByHallId(this IGenericRepository<Seat> _seatRepo, int hallId)
        {
            return _seatRepo.Find(s => s.HallId.Equals(hallId));
        }
    }
}
