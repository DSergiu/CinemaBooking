namespace Cinema.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class Ticket
    {
        [DataMember]
        public int TicketId { get; set; }

        [DataMember]
        [Required]
        public int Row { get; set; }

        [DataMember]
        [Required]
        public int Column { get; set; }

        [DataMember]
        [Display(Name = "Ticket Type Id")]
        [Required]
        public int TicketTypeId { get; set; }

        [DataMember]
        [Display(Name = "Booking Id")]
        [Required]
        public int BookingId { get; set; }

        [DataMember]
        public TicketType TicketType { get; set; }

        public Booking Booking { get; set; }       // removed virtual keyword for disabling lazy loading for Bookings object    
    }
}
