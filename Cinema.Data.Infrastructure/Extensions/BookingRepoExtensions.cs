namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class BookingRepoExtensions
    {
        public static void CreateBooking(this IGenericRepository<Booking> _bookingRepo, Booking booking)
        {
            booking.Paid = false;
            booking.CreatedOn = DateTime.UtcNow;

            _bookingRepo.Insert(booking);
        }

        public static Booking GetBooking(this IGenericRepository<Booking> _bookingRepo, int bookingId)
        {
            return _bookingRepo.Find(b => b.BookingId.Equals(bookingId), b => b.Tickets, b => b.User, b => b.Screening, b => b.Screening.ScreeningInfo).FirstOrDefault();
        }

        public static IQueryable<Booking> GetBookingsByUserGuid(this IGenericRepository<Booking> _bookingRepo, Guid userGuid)
        {
            return _bookingRepo.Find(b => b.User.UserGuid.Equals(userGuid));
        }

        public static IQueryable<Booking> GetBookingsByPhoneNo(this IGenericRepository<Booking> _bookingRepo, string phoneNo)
        {
            return _bookingRepo.Find(b => b.User.Phone.Equals(phoneNo));
        }

        public static IQueryable<Booking> GetBookingsByScreeningId(this IGenericRepository<Booking> _bookingRepo, int screeningId)
        {
            return _bookingRepo.Find(b => !b.IsCanceled && b.ScreeningId.Equals(screeningId), b => b.Tickets);
        }

        public static IQueryable<Booking> GetAllBookingsByPage(this IGenericRepository<Booking> _bookingRepo, int page, int noPerPage)
        {
            return _bookingRepo.Find(b => true, b => b.User).OrderBy(b => b.BookingId).Skip(page * (noPerPage - 1)).Take(noPerPage);
        }
    }
}
