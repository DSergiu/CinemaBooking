namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class SeatCtrl : ISeatCtrl
    {
        public void CreateSeat(Seat seat)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.SeatRepository.Insert(seat);
                uow.Save();
            }
        }

        public void UpdateSeat(Seat seat)
        {
            using (var uow = new EFUnitOfWork())
            {
                if (seat.Value == SeatType.NoSeat)
                {
                    uow.SeatRepository.Delete(seat);
                    uow.Save();
                }
                else
                {
                    try
                    {
                        uow.SeatRepository.Update(seat);
                        uow.Save();
                    }
                    catch
                    {
                        uow.SeatRepository.Insert(seat);
                        uow.Save();
                    }
                }
            }
        }

        public void DeleteSeat(Seat seat)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.SeatRepository.Delete(seat);
                uow.Save();
            }
        }
    }
}
