namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class SeatMap : EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            // Primary Key
            HasKey(t => new { t.HallId, t.Row, t.Column});

            // Properties
            Property(t => t.HallId).IsRequired();
            Property(t => t.Row).IsRequired();
            Property(t => t.Column).IsRequired();
            Property(t => t.Value).IsRequired();

            // Table & Column Mappings
            ToTable("Seat");
            Property(t => t.HallId).HasColumnName("HallId");
            Property(t => t.Row).HasColumnName("Row");
            Property(t => t.Column).HasColumnName("Column");
            Property(t => t.Value).HasColumnName("Value");

            // Relationships
            HasRequired(t => t.Hall).WithMany(t => t.Seats).HasForeignKey(d => d.HallId);
        }
    }
}
