namespace Cinema.WCFService.Attributes
{
    using System;
    using System.Net;
    using System.ServiceModel.Description;
    using System.ServiceModel.Dispatcher;
    using System.ServiceModel.Web;

    using Controller.Interfaces;
    using Controller.Classes;
    using Domain;


    public class Identity 
    {
        [ThreadStatic]          // each thread has its own static User variable
        public static User User;
    }


    public class AuthenticationAttribute : Attribute, IOperationBehavior, IParameterInspector
    {
        private ILoginTokenCtrl _loginToken;
        private ILoginTokenCtrl LoginTokenCtrl {
            get {
                _loginToken = _loginToken ?? new LoginTokenCtrl();
                return _loginToken;
            }
        }

        private AccessType Access;


        public AuthenticationAttribute() : this(AccessType.Basic) { }   //Set default to Basic access type

        public AuthenticationAttribute(AccessType accesstypeAllowed) {
            this.Access = accesstypeAllowed;
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(this);
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            string authTokenKey = WebOperationContext.Current.IncomingRequest.Headers["Authentication"];

            LoginToken authLoginToken = LoginTokenCtrl.GetLoginToken(authTokenKey);

            if (authLoginToken == null || authLoginToken.User.AccessLevel < Access)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
                throw new UnauthorizedAccessException("");
            }

            Identity.User = authLoginToken.User;

            return null;
        }

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void Validate(OperationDescription operationDescription)
        {
        }
    }
}
