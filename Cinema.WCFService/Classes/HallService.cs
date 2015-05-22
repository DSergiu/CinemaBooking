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

    public partial class CinemaService : IHallService
    {
        private IHallCtrl _hallCtrl;
        private IHallCtrl HallCtrl {
            get {
                _hallCtrl = _hallCtrl ?? new HallCtrl();

                return _hallCtrl;
            }
        }


        public int CreateHall(Hall hall)
        {
            Validation.Validate(hall);

            try
            {
                return HallCtrl.CreateHall(hall);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateHall(Hall hall, string hallId)
        {
            try
            {
                HallCtrl.UpdateHall(hall, hallId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteHall(string hallId)
        {
            try
            {
                HallCtrl.DeleteHall(hallId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public Hall GetHall(string hallId)
        {
            try
            {
                return HallCtrl.GetHall(hallId);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public Hall GetHallByName(string hallName)
        {
            try
            {
                return HallCtrl.GetHallByName(hallName);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public ICollection<Hall> GetAllHalls()
        {
            try
            {
                return HallCtrl.GetAllHalls();
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

    }
}
