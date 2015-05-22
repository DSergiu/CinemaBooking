namespace Cinema.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class TicketType
    {
        public TicketType()
        {
            Tickets = new List<Ticket>();
        }

        [DataMember]
        [Display(Name = "Ticket Type Id")]
        public int TicketTypeId { get; set; }

        [DataMember]
        [Display(Name="Ticket Type")]
        [Required]
        public string Type { get; set; }

        [DataMember]
        [Required]
        [Range(0,100)]
        public byte Discount { get; set; }

        public ICollection<Ticket> Tickets { get; set; }    // removed virtual keyword for disabling lazy loading for Tickets object
    }
}
