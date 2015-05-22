namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class ScreeningInfoCtrl : IScreeningInfoCtrl
    {
        public ScreeningInfo GetScreeningInfo(string screeningInfoId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeningInfoId);
            }
            catch
            {
                throw new ArgumentException("Screening Info Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.ScreeningInfoRepository.GetScreening(screeningIdInt);
            }
        }

        public ICollection<ScreeningInfo> GetScreeningInfosByMovieId(string movieId)
        {
            int movieIdInt;
            try
            {
                movieIdInt = Int32.Parse(movieId);
            }
            catch
            {
                throw new ArgumentException("Movie Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.ScreeningInfoRepository.GetScreeningInfosByMovieId(movieIdInt).ToArray();
            }
        }

        public ICollection<ScreeningInfo> GetScreeningInfosByPage(string page, string noperpage)
        {
            int pageInt, noperpageInt;
            try
            {
                pageInt = Int32.Parse(page);
                noperpageInt = Int32.Parse(noperpage);
            }
            catch
            {
                throw new ArgumentException("Page and number per page must be numeric values");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.ScreeningInfoRepository.GetScreeningInfosByPage(pageInt, noperpageInt).ToArray();
            }
        }


        public int CreateScreeningInfo(ScreeningInfo screeningInfo)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningInfoRepository.Insert(screeningInfo);
                uow.Save();

                return screeningInfo.ScreeningInfoId;
            }
        }

        public void UpdateScreeningInfo(ScreeningInfo screeningInfo, string screeninginfoId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeninginfoId);
            }
            catch
            {
                throw new ArgumentException("Screening Info Id must be a number");
            }

            screeningInfo.ScreeningInfoId = screeningIdInt;

            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningInfoRepository.Update(screeningInfo);
                uow.Save();
            }
        }

        public void DeleteScreeningInfo(string screeninginfoId)
        {
            int screeningIdInt;
            try
            {
                screeningIdInt = Int32.Parse(screeninginfoId);
            }
            catch
            {
                throw new ArgumentException("Screening Info Id must be a number");
            }

            using (var uow = new EFUnitOfWork())
            {
                uow.ScreeningInfoRepository.DeleteById(screeningIdInt);
                uow.Save();
            }
        }
    }
}
