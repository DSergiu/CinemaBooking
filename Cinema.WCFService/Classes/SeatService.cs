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

    public partial class CinemaService : ISeatService
    {
        private ISeatCtrl _seatCtrl;
        private ISeatCtrl SeatCtrl {
            get {
                _seatCtrl = _seatCtrl ?? new SeatCtrl();

                return _seatCtrl;
            }
        }

        public void CreateSeat(Seat seat)
        {
            Validation.Validate(seat);

            try
            {
                SeatCtrl.CreateSeat(seat);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void UpdateSeat(Seat seat)
        {
            Validation.Validate(seat);

            try
            {
                SeatCtrl.UpdateSeat(seat);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void UpdateOrInsertSeat(ICollection<Seat> seats)
        {
            try
            {
                //SeatCtrl.UpdateOrInsertSeats(seat);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteSeat(Seat seat)
        {
            Validation.Validate(seat);

            try
            {
                SeatCtrl.DeleteSeat(seat);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }
    }
}
