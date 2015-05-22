namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IScreeningCtrl
    {
        Screening GetScreening(string screeningId);
        ICollection<Screening> GetScreeningByPage(string page, string noPerPage);
        ICollection<Seat> GetSugestion(string screeningId, string noOfTickets);
        int CreateScreening(Screening screening);
        void UpdateScreening(Screening screening, string screeningId);
        void DeleteScreening(string screeningId);
    }
}
