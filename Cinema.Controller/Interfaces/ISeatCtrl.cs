namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface ISeatCtrl
    {
        void CreateSeat(Seat seat);
        void UpdateSeat(Seat seat);
        void DeleteSeat(Seat seat);
    }
}
