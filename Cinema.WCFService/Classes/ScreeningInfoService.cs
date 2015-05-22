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

    public partial class CinemaService : IScreeningInfoService
    {
        private IScreeningInfoCtrl _screeningInfoCtrl;
        private IScreeningInfoCtrl ScreeningInfoCtrl
        {
            get {
                _screeningInfoCtrl = _screeningInfoCtrl ?? new ScreeningInfoCtrl();

                return _screeningInfoCtrl;
            }
        }
        
        public int CreateScreeningInfo(ScreeningInfo screeninginfo)
        {
            Validation.Validate(screeninginfo);

            try
            {
                return ScreeningInfoCtrl.CreateScreeningInfo(screeninginfo);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateScreeningInfo(ScreeningInfo screeninginfo, string screeninginfoId)
        {
            Validation.Validate(screeninginfo);

            try
            {
                ScreeningInfoCtrl.UpdateScreeningInfo(screeninginfo, screeninginfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteScreeningInfo(string screeninginfoId)
        {
            try
            {
                ScreeningInfoCtrl.DeleteScreeningInfo(screeninginfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public ScreeningInfo GetScreeningInfo(string screeninginfoId)
        {
            try
            {
                return ScreeningInfoCtrl.GetScreeningInfo(screeninginfoId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<ScreeningInfo> GetScreeningInfosByMovieId(string movieId)
        {
            try
            {
                return ScreeningInfoCtrl.GetScreeningInfosByMovieId(movieId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }


        public ICollection<ScreeningInfo> GetScreeningInfosByPage(string page, string noperpage)
        {
            try
            {
                return ScreeningInfoCtrl.GetScreeningInfosByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
