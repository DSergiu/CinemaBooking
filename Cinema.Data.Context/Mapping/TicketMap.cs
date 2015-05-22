namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            // Primary Key
            HasKey(t => t.TicketId);

            // Properties
            Property(t => t.Row).IsRequired();
            Property(t => t.Column).IsRequired();
            Property(t => t.TicketTypeId).IsRequired();
            Property(t => t.BookingId).IsRequired();

            // Table & Column Mappings
            ToTable("Ticket");
            Property(t => t.TicketId).HasColumnName("TicketId");
            Property(t => t.Row).HasColumnName("Row");
            Property(t => t.Column).HasColumnName("Column");
            Property(t => t.TicketTypeId).HasColumnName("TicketTypeId");
            Property(t => t.BookingId).HasColumnName("BookingId");

            // Relationships
            HasRequired(t => t.TicketType).WithMany(t => t.Tickets).HasForeignKey(d => d.TicketTypeId).WillCascadeOnDelete(false);
            HasRequired(t => t.Booking).WithMany(t => t.Tickets).HasForeignKey(d => d.BookingId);
        }
    }
}
