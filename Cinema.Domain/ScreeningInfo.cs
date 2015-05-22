namespace Cinema.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class ScreeningInfo
    {
        public ScreeningInfo()
        {
            Screenings = new List<Screening>();
        }

        [DataMember]
        public int ScreeningInfoId { get; set; }

        [DataMember]
        [Required]
        public int MovieId { get; set; }

        [DataMember]
        [Required]
        public float TicketPrice { get; set; }

        [DataMember]
        [Required]
        public int HallId { get; set; }

        [DataMember]
        public virtual Movie Movie { get; set; }

        [DataMember]
        public virtual Hall Hall { get; set; }
        
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
