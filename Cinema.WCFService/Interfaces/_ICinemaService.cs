namespace Cinema.WCFService.Interfaces
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ICinemaService : IUserService, IBookingService, IHallService, ISeatService, ITicketService, ITicketTypeService, IMovieService, IMovieInfoService, IScreeningService, IScreeningInfoService
    {

    }
}
