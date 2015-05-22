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

    public partial class CinemaService : IScreeningService
    {
        private IScreeningCtrl _screeningCtrl;
        private IScreeningCtrl ScreeningCtrl
        {
            get {
                _screeningCtrl = _screeningCtrl ?? new ScreeningCtrl();

                return _screeningCtrl;
            }
        }

        public int CreateScreening(Screening screening)
        {
            Validation.Validate(screening);

            try
            {
                return ScreeningCtrl.CreateScreening(screening);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateScreening(Screening screening, string screeningId)
        {
            Validation.Validate(screening);

            try
            {
                ScreeningCtrl.UpdateScreening(screening, screeningId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteScreening(string screeningId)
        {
            try
            {
                ScreeningCtrl.DeleteScreening(screeningId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public Screening GetScreening(string screeningId)
        {
            try
            {
                return ScreeningCtrl.GetScreening(screeningId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Screening> GetScreeningsPerPage(string page, string noperpage)
        {
            try
            {
                return ScreeningCtrl.GetScreeningByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Seat> GetSeatsSuggestion(string screeningId, string noOfTickets)
        {
            try
            {
                return ScreeningCtrl.GetSugestion(screeningId, noOfTickets);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
