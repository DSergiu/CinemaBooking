namespace Cinema.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class Booking
    {
        public Booking() {
            Tickets = new List<Ticket>();
        }

        public Booking(Guid userGuid, int screeningId) : this()
        {
            UserGuid = userGuid;
            ScreeningId = screeningId;
        }

        [DataMember]
        public int BookingId { get; set; }


        [DataMember]
        [Required]
        public Guid UserGuid { get; set; }


        [DataMember]
        [Display(Name = "Screening Id")]
        [Required]
        public int ScreeningId { get; set; }


        [DataMember]
        public float TotalPrice { get; set; }


        [DataMember]
        public bool Paid { get; set; }


        [DataMember]
        public bool IsCanceled { get; set; }


        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public Guid CreatedBy { get; set; }

        [DataMember]
        public virtual ICollection<Ticket> Tickets { get; set; }

        [DataMember]
        public User User { get; set; }
        [DataMember]
        public Screening Screening { get; set; }
    }
}
