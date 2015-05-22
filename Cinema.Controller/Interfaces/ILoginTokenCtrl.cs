namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface ILoginTokenCtrl
    {
        LoginToken GetLoginToken(string logintokenGuid);
    }
}
