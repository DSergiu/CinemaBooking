namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class ScreeningInfoMap : EntityTypeConfiguration<ScreeningInfo>
    {
        public ScreeningInfoMap()
        {
            // Primary Key
            HasKey(t => t.ScreeningInfoId);

            // Properties
            Property(t => t.MovieId).IsRequired();
            Property(t => t.HallId).IsRequired();
            Property(t => t.TicketPrice).IsRequired();
            

            // Table & Column Mappings
            ToTable("ScreeningInfo");
            Property(t => t.TicketPrice).HasColumnName("TicketPrice");
            Property(t => t.ScreeningInfoId).HasColumnName("ScreeningInfoId");
            Property(t => t.MovieId).HasColumnName("MovieId");
            Property(t => t.HallId).HasColumnName("HallId");

            // Relationships
            HasRequired(t => t.Movie).WithMany().HasForeignKey(d => d.MovieId);
            HasRequired(t => t.Hall).WithMany().HasForeignKey(d => d.HallId);
        }
    }
}
