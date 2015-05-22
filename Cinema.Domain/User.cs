namespace Cinema.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    
    [DataContract]
    public class User
    {
        public User()
        {
            Bookings = new List<Booking>();
        }

        public User(string email, string phone, string password) : this()
        {
            Email = email;
            Phone = phone;
            Password = password;            
        }


        [DataMember]
        public Guid UserGuid { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [RegularExpression(@"^[\w-.]{2,}@[\w-]{2,}.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid {0}.")]
        public string Email { get; set; }


        public string Salt { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [DataMember]
        [Display(Name = "Last Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage="Invalid {0}. It must contain at least 2 characters.")]
        public string LastName { get; set; }
        

        [DataMember]
        [Display(Name = "First Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$", ErrorMessage="Invalid {0}. It must contain at least 2 characters.")]
        public string FirstName { get; set; }


        [DataMember]
        [Display(Name = "Phone number")]
        [Required]
        [RegularExpression(@"\+?(\d){7,14}$", ErrorMessage="Invalid {0}. (e.g. +4540789162 | 40789162)")]
        public string Phone { get; set; }


        [DataMember]
        [EnumDataType(typeof(AccessType))]
        public AccessType AccessLevel { get; set; }

        
        [DataMember]
        public DateTime LastLogin { get; set; }

        [DataMember]
        public Guid CreatedBy { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public Guid? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? UpdatedOn { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
        
        
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<LoginToken> LoginToken { get; set; }
    }
}
