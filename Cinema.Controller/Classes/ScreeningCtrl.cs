namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class ScreeningCtrl : IScreeningCtrl
    {
        public Screening GetScreening(string screeningId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeningId);
            }
            catch
            {
                throw new ArgumentException("Screening Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.ScreeningRepository.GetScreening(screeningIdInt);
            }
        }

        public ICollection<Screening> GetScreeningByPage(string page, string noPerPage)
        {
            int pageInt, noPerPageInt;
            try
            {
                pageInt = Int32.Parse(page);
                noPerPageInt = Int32.Parse(noPerPage);
            }
            catch
            {
                throw new ArgumentException("Page and Number per page must be numeric values");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.ScreeningRepository.GetScreeningByPage(pageInt,noPerPageInt).ToArray();
            }
        }

        public ICollection<Seat> GetSugestion(string screeningId, string noOfTickets)
        {
            int screeningIdInt;
            int noOfTicketsInt;
            try
            {
                screeningIdInt = Int32.Parse(screeningId);
                noOfTicketsInt = Int32.Parse(noOfTickets);
            }
            catch
            {
                throw new ArgumentException("Screening Id and Number of tickets must be a number");
            }

            if (noOfTicketsInt <= 0 || noOfTicketsInt > 9)
            {
                throw new ArgumentException("Number of tickets must be greater than 0 and smaller than 9");
            }


            using (var uow = new EFUnitOfWork())
            {
                Screening screening = uow.ScreeningRepository.GetScreening(screeningIdInt);

                if(screening == null)
                {
                    throw new ArgumentException("Invalid screening ID.");
                }

                Booking[] bookings = uow.BookingRepository.GetBookingsByScreeningId(screening.ScreeningId).ToArray();

                // Select only Normal Seats for Suggestions, as Seats for people with handicap are choosen manually
                ICollection<Seat> seatMap = screening.ScreeningInfo.Hall.Seats.Where(s => s.Value.Equals(SeatType.NormalSeat)).ToList();  
                

                foreach (var booking in bookings)
                    foreach (var ticket in booking.Tickets)
                    {
                        Seat search = seatMap.FirstOrDefault(s => s.Equals(new Seat { Row = ticket.Row, Column = ticket.Column}));

                        seatMap.Remove(search); // remove the booked seat from the seatMap
                    }
                
                Seat[] suggestion = screening.GetSuggestion(seatMap.ToArray(), noOfTicketsInt);

                if (suggestion == null)
                {
                    throw new ArgumentException("There are no enough available seats for this booking.");
                }

                return suggestion;
            }
        }

        public int CreateScreening(Screening screening)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningRepository.Insert(screening);
                uow.Save();

                return screening.ScreeningId;
            }
        }

        public void UpdateScreening(Screening screening, string screeningId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeningId);
            }
            catch
            {
                throw new ArgumentException("Screening Id must be a number");
            }

            screening.ScreeningId = screeningIdInt;

            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningRepository.Update(screening);
                uow.Save();
            }
        }

        public void DeleteScreening(string screeningId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeningId);
            }
            catch
            {
                throw new ArgumentException("Screening Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningRepository.DeleteById(screeningIdInt);
                uow.Save();
            }
        }
    }
}
