namespace Cinema.Domain
{
    using System;

    public class LoginToken
    {
        public virtual Guid TokenKey { get; set; }
        public virtual Guid UserGuid { get; set; }
        public virtual DateTime TokenExpiration { get; set; }        
        public bool IsValid { get { return TokenExpiration > DateTime.Now; } }
        public User User { get; set; }        
    }
}
