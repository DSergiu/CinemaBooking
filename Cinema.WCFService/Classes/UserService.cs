namespace Cinema.WCFService.Classes
{
    using System;
    using Interfaces;

    using Domain;
    using Cinema.Controller.Interfaces;
    using Cinema.Controller.Classes;

    using System.ServiceModel.Web;
    using System.Web.Mvc;
    using System.Data.Entity.Validation;
    using Models;

    using AutoMapper;
    using System.Collections.Generic;
    using System.Reflection;

    public partial class CinemaService : IUserService
    {
        private IUserCtrl _userCtrl;
        private IUserCtrl UserCtrl
        {
            get
            {
                _userCtrl = _userCtrl ?? new UserCtrl();

                return _userCtrl;
            }
        }


        public LoginResult Login(UserLogin model)
        {
            Validation.Validate(model);

            try
            {
                LoginToken loginToken = UserCtrl.LogIn(model.emailORphone, model.password);
                return new LoginResult(loginToken);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }


        public CreateUserResult CreateUser(UserRegister model)
        {
            Validation.Validate(model);

            try
            {                
                Mapper.CreateMap<UserRegister, User>();
                User user = Mapper.Map<UserRegister, User>(model);

                //Who created this user? An Employee or the System ?
                user.CreatedBy = Attributes.Identity.User.UserGuid == Guid.Empty
                                ? new Guid(Constants.SystemAccountGuid)
                                : Attributes.Identity.User.UserGuid;

                Guid userKey = UserCtrl.CreateUser(user);
                return new CreateUserResult { UserKey = userKey };
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                user.UpdatedBy = Attributes.Identity.User.UserGuid;

                UserCtrl.UpdateUser(user);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        public void DeleteUser(String userid)
        {
            try
            {
                UserCtrl.DeleteUser(userid);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex);
            }
        }

        
        public User GetUserProfile()
        {
            try
            {
                User user = UserCtrl.GetUser(Attributes.Identity.User.UserGuid.ToString());
                return user;
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public User GetUser(string userGuid)            
        {
            try
            {
                return UserCtrl.GetUser(userGuid);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }

        public User GetUserByEmail(string email)
        {
            return UserCtrl.GetUserByEmail(email);
        }

        public User GetUserByPhone(string phone)
        {
            return UserCtrl.GetUserByPhone(phone);
        }

        public ICollection<User> GetusersByPage(string page, string noperpage)
        {
            try
            {
                return UserCtrl.GetUsersByPage(page, noperpage);
            }
            catch (Exception ex)
            {
                Validation.BadRequest(ex); throw;
            }
        }
    }
}
