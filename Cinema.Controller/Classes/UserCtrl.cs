namespace Cinema.Controller.Classes
{
    using System;
    using System.Linq;
    using System.Transactions;
    using System.Collections.Generic;

    using Interfaces;
    using Domain;
    using Data.Infrastructure;

    public class UserCtrl : IUserCtrl
    {
        public Guid CreateUser(User user)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.UserRepository.CheckUser(user);

                user.Salt = EncryptionUtil.CreateSalt(10);
                user.Password = EncryptionUtil.CreatePasswordHash(user.Password, user.Salt);

                Guid userGuid = uow.UserRepository.CreateUser(user);
                uow.Save();

                return userGuid;
            }
        }

        public LoginToken LogIn(string emailORphone, string password)
        {
            using (var uow = new EFUnitOfWork())
            {
                User user = uow.UserRepository.GetUserByEmail(emailORphone) ?? uow.UserRepository.GetUserByPhone(emailORphone);

                if (user == null)
                {
                    throw new ArgumentException("Invalid Credentials.");
                }

                string pwHashed = EncryptionUtil.CreatePasswordHash(password, user.Salt);

                if (!user.Password.Equals(pwHashed))
                {
                    throw new ArgumentException("Invalid Credentials.");
                }

                LoginToken loginToken = uow.LoginTokenRepository.CreateLoginToken(user.UserGuid);

                user.LastLogin = DateTime.UtcNow;
                uow.UserRepository.Update(user);

                uow.Save();

                loginToken.User = user;

                return loginToken;
            }
        }


        public User GetUser(string userGuid)
        {
            Guid userGuidGuid;

            try
            {
                userGuidGuid = new Guid(userGuid);
            }
            catch
            {
                throw new ArgumentException("Invalid User Id");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.UserRepository.GetUser(userGuidGuid);
            }
        }

        public User GetUserByEmail(string email)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.UserRepository.GetUserByEmail(email);
            }
        }

        public User GetUserByPhone(string phone)
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.UserRepository.GetUserByPhone(phone);
            }
        }

        public void UpdateUser(User user) 
        {
            using (var uow = new EFUnitOfWork())
            {
                User userdb = uow.UserRepository.GetByID(user.UserGuid);

                if(userdb == null)
                {
                    throw new ArgumentException("Invalid User Id");
                }

                userdb.Email = user.Email;
                userdb.FirstName = user.FirstName;
                userdb.LastName = user.LastName;
                userdb.Phone = user.Phone;
                userdb.AccessLevel = user.AccessLevel;
                userdb.IsDeleted = user.IsDeleted;
                userdb.UpdatedBy = user.UpdatedBy;
                userdb.UpdatedOn = DateTime.UtcNow;

                uow.UserRepository.Update(userdb);
                uow.Save();
            }
        }

        public void DeleteUser(String userid)
        {
            Guid userGuid;

            try
            {
                userGuid = new Guid(userid);
            }
            catch
            {
                throw new ArgumentException("Invalid User Id");
            }

            using (var uow = new EFUnitOfWork())
            {
                User user = uow.UserRepository.GetByID(userGuid);

                if(user == null)
                {
                    throw new ArgumentException(String.Format("This user ({0}) does not exist.", userGuid));
                }

                user.IsDeleted = true;

                uow.UserRepository.Update(user);
            }
        }

        public ICollection<User> GetUsersByPage(string page, string noperpage)
        {
            int pageInt, noPerPageInt;
            try
            {
                pageInt = Int32.Parse(page);
                noPerPageInt = Int32.Parse(noperpage);
            }
            catch
            {
                throw new ArgumentException("Page and number per page must be numeric values");
            }

            using (var uow = new EFUnitOfWork())
            {
                return uow.UserRepository.GetUsersByPage(pageInt, noPerPageInt).ToArray();
            }
        }
    }
}
