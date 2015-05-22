namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class ScreeningMap : EntityTypeConfiguration<Screening>
    {
        public ScreeningMap()
        {
            // Primary Key
            HasKey(t => t.ScreeningId);

            // Properties
            Property(t => t.ScreeningInfoId).IsRequired();
            Property(t => t.ScreeningDateTime).IsRequired();

            // Table & Column Mappings
            ToTable("Screening");
            Property(t => t.ScreeningId).HasColumnName("ScreeningId");
            Property(t => t.ScreeningInfoId).HasColumnName("ScreeningInfoId");
            Property(t => t.ScreeningDateTime).HasColumnName("ScreeningDateTime");

            // Relationships
            HasRequired(t => t.ScreeningInfo).WithMany(t => t.Screenings).HasForeignKey(d => d.ScreeningInfoId);
        }
    }
}
