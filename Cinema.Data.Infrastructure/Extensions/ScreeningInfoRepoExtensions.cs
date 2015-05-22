namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class ScreeningInfoRepoExtensions
    {
        public static ScreeningInfo GetScreening(this IGenericRepository<ScreeningInfo> _screeninginfoRepo, int screeningId)
        {
            return _screeninginfoRepo.Find(si => si.ScreeningInfoId.Equals(screeningId)).FirstOrDefault();
        }

        public static IQueryable<ScreeningInfo> GetScreeningInfosByMovieId(this IGenericRepository<ScreeningInfo> _screeninginfoRepo, int movieIdInt)
        {
            return _screeninginfoRepo.Find(si => si.MovieId.Equals(movieIdInt));
        }

        public static IQueryable<ScreeningInfo> GetScreeningInfosByPage(this IGenericRepository<ScreeningInfo> _screeninginfoRepo, int page, int noperpage)
        {
            return _screeninginfoRepo.Find(si => true).OrderBy(si => si.ScreeningInfoId).Skip(page * (noperpage - 1)).Take(noperpage);
        }
        
    }
}
