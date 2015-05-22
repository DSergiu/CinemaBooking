namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class HallRepoExtensions
    {
        public static Hall GetHall(this IGenericRepository<Hall> _hallRepo, int hallId)
        {
            return _hallRepo.Find(h => h.HallId.Equals(hallId), h => h.Seats).FirstOrDefault();
        }

        public static Hall GetHallByName(this IGenericRepository<Hall> _hallRepo, string hallName)
        {
            return _hallRepo.Find(h => h.HallName.Equals(hallName), h => h.Seats).FirstOrDefault();
        }

        public static IQueryable<Hall> GetAllHalls(this IGenericRepository<Hall> _hallRepo)
        {
            return _hallRepo.Find(h => true);
        }
    }
}
