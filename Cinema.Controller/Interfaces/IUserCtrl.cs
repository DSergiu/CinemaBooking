namespace Cinema.Controller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Cinema.Domain;

    public interface IUserCtrl
    {
        User GetUser(string userGuid);
        User GetUserByEmail(string email);
        User GetUserByPhone(string phone);
        ICollection<User> GetUsersByPage(string page, string noperpage);
        LoginToken LogIn(string emailORphone, string password);
        

        Guid CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(String userid);
    }
}
