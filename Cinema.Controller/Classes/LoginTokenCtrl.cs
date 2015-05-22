namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Cinema.Domain;
    using Interfaces;
    using Cinema.Data.Infrastructure;

    public class LoginTokenCtrl : ILoginTokenCtrl
    {
        public LoginToken GetLoginToken(string logintokenGuid)
        {
            Guid logintokenguidGuid;

            try
            {
                logintokenguidGuid = new Guid(logintokenGuid);
            }
            catch
            {
                return null;
            }

            using (var uow = new EFUnitOfWork())
            {
                LoginToken login = uow.LoginTokenRepository.GetLoginToken(logintokenguidGuid);

                if (login!=null && login.IsValid)
                    return login;

                return null;    // it is not valid
            }
        }
    }
}
