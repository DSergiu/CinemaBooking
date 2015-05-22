namespace Cinema.WCFService.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public class UserRegister
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"\+?(\d){7,14}$", ErrorMessage = "Invalid {0}. It must contain at least 7 digits.")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^\w{2,}$", ErrorMessage = "Invalid {0}. It must contain at least 2 characters.")]
        [Display(Name = "Last Name")]       
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^\w{2,}$", ErrorMessage = "Invalid {0}. It must contain at least 2 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,20}$", ErrorMessage = "The password requires at least one lower case letter, one upper case letter, one digit, 8-20 length.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm new password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "An email or phone is required")]
        [Display(Name="email / phone")]
        public string emailORphone { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,20}$", ErrorMessage = "The password requires at least one lower case letter, one upper case letter, one digit, 8-20 length.")]
        [Display(Name="Password")]
        public string password { get; set; }
    }

    [DataContract]
    public class LoginResult
    {
        public LoginResult(Cinema.Domain.LoginToken loginToken) 
        {
            TokenKey = loginToken.TokenKey;
            Email = loginToken.User.Email;
            Name = loginToken.User.FirstName + " " + loginToken.User.LastName;
        }
        [DataMember]
        public Guid TokenKey { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    public class CreateUserResult
    {
        public Guid UserKey { get; set; }
    }
}