namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;

    using Domain;

    public static class LoginTokenRepoExtensions
    {
        public static LoginToken CreateLoginToken(this IGenericRepository<LoginToken> _logintokenRepo, Guid userGuid)
        {
            LoginToken loginToken = new LoginToken();
            loginToken.UserGuid = userGuid;
            loginToken.TokenKey = Guid.NewGuid();
            loginToken.TokenExpiration = DateTime.UtcNow.AddDays(1);    //make token valid for 1 day

            _logintokenRepo.Insert(loginToken);

            return loginToken;
        }

        public static LoginToken GetLoginToken(this IGenericRepository<LoginToken> _logintokenRepo, Guid loginToken)
        {
            return _logintokenRepo.Find(lt => lt.TokenKey.Equals(loginToken), lt => lt.User).OrderByDescending(lt => lt.TokenExpiration).FirstOrDefault();
        }
    }
}
