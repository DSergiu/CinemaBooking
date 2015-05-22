namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IHallCtrl
    {
        Hall GetHall(string hallId);
        Hall GetHallByName(string hallName);
        ICollection<Hall> GetAllHalls();

        int CreateHall(Hall hall);
        void UpdateHall(Hall hall, string hallId);
        void DeleteHall(string hallId);
    }
}
