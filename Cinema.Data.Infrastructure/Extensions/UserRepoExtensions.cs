namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class UserRepoExtensions
    {
        public static Guid CreateUser(this IGenericRepository<User> _userRepo, User user)
        {
            user.LastLogin = DateTime.UtcNow;
            user.CreatedOn = DateTime.UtcNow;
            user.UserGuid = Guid.NewGuid();
            user.AccessLevel = AccessType.Basic;

            _userRepo.Insert(user);

            return user.UserGuid;
        }

        public static void CheckUser(this IGenericRepository<User> _userRepo, User user)
        {
            User auxUser = _userRepo.Find(u => u.Email.Equals(user.Email) || u.Phone.Equals(user.Phone)).FirstOrDefault();

            if (auxUser != null)
            {
                throw new ArgumentException("Account with this email or phone already exists");
            }
        }

        public static User GetUser(this IGenericRepository<User> _userRepo, Guid userGuid)
        {
            return _userRepo.Find(u => u.UserGuid.Equals(userGuid)).FirstOrDefault();
        }

        public static User GetUserByEmail(this IGenericRepository<User> _userRepo, string email)
        {
            return _userRepo.Find(u => u.Email.Equals(email)).FirstOrDefault();
        }

        public static User GetUserByPhone(this IGenericRepository<User> _userRepo, string phone)
        {
            return _userRepo.Find(u => u.Phone.Equals(phone)).FirstOrDefault();
        }

        public static IQueryable<User> GetUsersByPage(this IGenericRepository<User> _userRepo, int page, int noPerPage)
        {
            return _userRepo.Find(u => true).OrderBy(u => u.CreatedOn).Skip(page * (noPerPage - 1)).Take(noPerPage);
        }
        
    }
}
