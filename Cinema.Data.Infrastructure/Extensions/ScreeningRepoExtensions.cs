namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class ScreeningRepoExtensions
    {
        public static Screening GetScreening(this IGenericRepository<Screening> _screeningRepo, int screeningId)
        {
            return _screeningRepo.Find(s => s.ScreeningId.Equals(screeningId), s => s.ScreeningInfo, s => s.ScreeningInfo.Hall, s => s.ScreeningInfo.Hall.Seats, s => s.ScreeningInfo.Movie).FirstOrDefault();
        }

        public static IQueryable<Screening> GetScreeningByPage(this IGenericRepository<Screening> _screeningRepo, int page, int noPerPage)
        {
            return _screeningRepo.Find(s => true).OrderBy(s => s.ScreeningId).Skip(page * (noPerPage - 1)).Take(noPerPage);
        }
    }
}
