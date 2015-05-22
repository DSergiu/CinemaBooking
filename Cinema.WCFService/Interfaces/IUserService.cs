namespace Cinema.WCFService.Interfaces
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    using Models;
    using Domain;
    using Attributes;
    using System.Collections.Generic;    

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebInvoke(Method = "POST", UriTemplate = "login")]
        LoginResult Login(UserLogin model);

        [OperationContract]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [WebInvoke(Method = "POST", UriTemplate = "user")]
        CreateUserResult CreateUser(UserRegister model);

        [Authentication]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "user")]
        void UpdateUser(User user);


        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "user/{userid}")]
        void DeleteUser(String userid);


        [Authentication]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "user/profile")]
        User GetUserProfile();

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "user/{userGuid}")]
        User GetUser(string userGuid);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "user/email/{email}")]
        User GetUserByEmail(string email);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "user/phone/{phone}")]
        User GetUserByPhone(string phone);

        [Authentication(AccessType.Employee)]
        [FaultContractAttribute(typeof(System.Collections.Generic.ICollection<ValidationError>))]
        [OperationContract]
        [WebGet(UriTemplate = "users/page/{page}/{noperpage}")]
        ICollection<User> GetusersByPage(string page, string noperpage);
    }
}
