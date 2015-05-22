namespace Cinema.Data.Infrastructure
{
    using System;
    using Domain;   

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Booking> BookingRepository { get; }
        IGenericRepository<Hall> HallRepository { get; }
        IGenericRepository<LoginToken> LoginTokenRepository { get; }
        IGenericRepository<MovieInfo> MovieInfoRepository { get; }
        IGenericRepository<Movie> MovieRepository { get; }
        IGenericRepository<ScreeningInfo> ScreeningInfoRepository { get; }
        IGenericRepository<Screening> ScreeningRepository { get; }
        IGenericRepository<Seat> SeatRepository { get; }
        IGenericRepository<Ticket> TicketRepository { get; }
        IGenericRepository<TicketType> TicketTypeRepository { get; }
        IGenericRepository<User> UserRepository { get; }


        void Save();
    }
}
