namespace Cinema.WCFService.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.Entity.Validation;
    using System.Web.Script.Serialization;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.ServiceModel.Web;
   
    public static class Validation
    {

        public static void Validate(object model)
        {
            if (model == null)
                ThrowBadRequest(generalException("Empty object.")); 

            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);


            if (validationResults.Count > 0)
            {
                ICollection<ValidationError> errors = validationResults.Select(v => new ValidationError{ErrorMessage = v.ErrorMessage, PropertyName = v.MemberNames.Count() > 0 ? v.MemberNames.First() : null }).ToArray();
                ThrowBadRequest(errors);
            }
        }



        public static void BadRequest(Exception ex)
        {
            ICollection<ValidationError> errors;

            if (ex.GetType() == typeof(DbEntityValidationException))
                errors = dbEntityValidationException(ex as DbEntityValidationException);
            else if (ex.GetType() == typeof(ArgumentException))
                errors = argumentException(ex as ArgumentException);
            else
                errors = generalException(null);

            ThrowBadRequest(errors);
        }

        private static ICollection<ValidationError> argumentException(ArgumentException ex){
            ICollection<ValidationError> errors = new List<ValidationError>();
            errors.Add(new ValidationError(ex.Message));
            return errors;
        }

        private static ICollection<ValidationError> generalException(string message){
            if (String.IsNullOrEmpty(message))
                message = "An error occurred. Try again or contact the sysadmin.";

            ICollection<ValidationError> errors = new List<ValidationError>();
            errors.Add(new ValidationError(message));
            return errors;
        }

        private static ICollection<ValidationError> dbEntityValidationException(DbEntityValidationException ex){
           return ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => new ValidationError(x)).ToArray();
        }

        private static void ThrowBadRequest(ICollection<ValidationError> errors) {
            throw new WebFaultException<ICollection<ValidationError>>(errors, System.Net.HttpStatusCode.BadRequest);
        }
    }


    [DataContract]
    public class ValidationError
    {
        public ValidationError() 
        { }

        public ValidationError(DbValidationError error) : this(error.PropertyName, error.ErrorMessage) 
        { }

        public ValidationError(string errorMessage) 
        {
            ErrorMessage = errorMessage;
        }

        public ValidationError(string propertyName, string errorMessage) 
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;
        }

        [DataMember]
        public string PropertyName { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}