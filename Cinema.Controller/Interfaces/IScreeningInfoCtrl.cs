namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IScreeningInfoCtrl
    {
        ScreeningInfo GetScreeningInfo(string screeningInfoId);
        ICollection<ScreeningInfo> GetScreeningInfosByMovieId(string movieId);
        ICollection<ScreeningInfo> GetScreeningInfosByPage(string page, string noperpage);

        int CreateScreeningInfo(ScreeningInfo screeningInfo);
        void UpdateScreeningInfo(ScreeningInfo screeningInfo, string screeninginfoId);
        void DeleteScreeningInfo(string screeninginfoId);
    }
}
