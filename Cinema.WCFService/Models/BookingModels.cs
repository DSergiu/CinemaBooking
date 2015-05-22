namespace Cinema.WCFService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class BookingModel : IValidatableObject
    {
        [Display(Name = "Screening Id")]
        [Required]
        public int? ScreeningId { get; set; }

        [Display(Name = "Customer Id")]
        [Required]
        public Guid? UserGuid { get; set; }

        [Required]
        public ICollection<TicketModel> Tickets { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var ticket in Tickets)
                Validation.Validate(ticket);

            return new List<ValidationResult>();
        }
    }

    public class TicketModel
    {
        [Required]
        public int? Row { get; set; }

        [Required]
        public int? Column { get; set; }

        [Display(Name = "Ticket Type")]
        [Required]
        public int? TicketTypeId { get; set; }
    }
}