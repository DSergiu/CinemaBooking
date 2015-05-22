namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class HallCtrl : IHallCtrl
    {
        public Hall GetHall(string hallId)
        {
            int hallIdInt;
            try
            {
                hallIdInt = Int32.Parse(hallId);
            }
            catch
            {
                throw new ArgumentException("Hall Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                Hall hall = uow.HallRepository.GetHall(hallIdInt);
                return hall;
            }
        }

        public Hall GetHallByName(string hallName)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.HallRepository.GetHallByName(hallName);
            }
        }

        public ICollection<Hall> GetAllHalls()
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.HallRepository.GetAllHalls().ToArray();
            }
        }

        public int CreateHall(Hall hall)
        {
            using (var uow = new EFUnitOfWork())
            {
                Hall halldb = uow.HallRepository.GetHallByName(hall.HallName);
                if (halldb != null)
                    throw new ArgumentException("The Hall name already exists in database.");

                uow.HallRepository.Insert(hall);
                uow.Save();

                return hall.HallId;
            }
        }

        public void UpdateHall(Hall hall, string hallId)
        {
            int hallIdInt;
            try
            {
                hallIdInt = Int32.Parse(hallId);
            }
            catch
            {
                throw new ArgumentException("Hall Id must be a number");
            }

            hall.HallId = hallIdInt;
            hall.Seats = null; // don't update the seats

            using (var uow = new EFUnitOfWork())
            {
                Hall halldb = uow.HallRepository.Find(h => h.HallName.Equals(hall.HallName) && !h.HallId.Equals(hall.HallId)).FirstOrDefault();

                if (halldb != null && !halldb.HallId.Equals(hall.HallId))
                    throw new ArgumentException("This hall name is already set for another hall.");
                
                uow.HallRepository.Update(hall);

                uow.Save();
            }
        }

        public void DeleteHall(string hallId)
        {
            int hallIdInt;
            try
            {
                hallIdInt = Int32.Parse(hallId);
            }
            catch
            {
                throw new ArgumentException("Hall Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.HallRepository.DeleteById(hallIdInt);
                uow.Save();
            }
        }
    }
}
