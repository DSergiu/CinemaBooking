namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;    
    using Domain;

    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            HasKey(t => t.BookingId);

            // Properties
            Property(t => t.UserGuid).IsRequired();
            Property(t => t.ScreeningId).IsRequired();

            // Table & Column Mappings
            ToTable("Booking");
            Property(t => t.BookingId).HasColumnName("BookingId");
            Property(t => t.UserGuid).HasColumnName("UserGuid");
            Property(t => t.ScreeningId).HasColumnName("ScreeningId");
            Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            Property(t => t.Paid).HasColumnName("Paid");
            Property(t => t.IsCanceled).HasColumnName("IsCanceled");
            Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            Property(t => t.CreatedBy).HasColumnName("UpdatedBy");     
            
            // Relationships
            HasRequired(t => t.User).WithMany(t => t.Bookings).HasForeignKey(d => d.UserGuid);
            HasRequired(t => t.Screening).WithMany(t => t.Bookings).HasForeignKey(d => d.ScreeningId);
        }
    }
}
