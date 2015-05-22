namespace DedicatedClient
{
    using System;
    using System.Linq;
    using CinemaService;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public static class CinemaClient
    {
        private static CinemaServiceClient _client;
        private static string _tokenKey;
        private static string _email, _name;

        public static CinemaServiceClient Client {
            get {
                if (_client == null)
                {
                    _client = new CinemaServiceClient();
                }

                if (TokenKey != null)   //if authentificated, set header Authentication value
                {
                    new OperationContextScope(_client.InnerChannel);
                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authentication"] = TokenKey;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                }
                
                return _client;
            }
        }

        public static string TokenKey {
            get {
                return _tokenKey;
            }

            set {
                _tokenKey = value;
            }
        }

        public static string Email {
            get {
                return _email;
            }

            set {
                _email = value;
            }
        }


        public static string Name {
            get {
                return _name;
            }

            set {
                _name = value;
            }
        }
    }
}
