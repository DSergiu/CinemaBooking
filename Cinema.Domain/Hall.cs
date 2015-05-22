namespace Cinema.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class Hall
    {
        public Hall()
        {
            Screenings = new List<Screening>();
            Seats = new List<Seat>();
        }

        [DataMember]
        public int HallId { get; set; }

        [DataMember]
        [Display(Name = "Hall Name")]
        [Required]
        public string HallName { get; set; }

        [DataMember]
        public ICollection<Seat> Seats { get; set; }

        public ICollection<Screening> Screenings { get; set; }
    }
}
