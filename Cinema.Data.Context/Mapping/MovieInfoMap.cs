namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;    
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Domain;

    public class MovieInfoMap : EntityTypeConfiguration<MovieInfo>
    {
        public MovieInfoMap()
        {
            // Primary Key
            HasKey(t => t.MovieInfoId);

            // Properties
            Property(t => t.Title).IsRequired().HasMaxLength(200);

            // Table & Column Mappings
            ToTable("MovieInfo");
            Property(t => t.MovieInfoId).HasColumnName("MovieInfoId");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Director).HasColumnName("Director");
            Property(t => t.Actors).HasColumnName("Actors");
            Property(t => t.ReleaseDate).HasColumnName("ReleaseDate");
            Property(t => t.LenghtTime).HasColumnName("LenghtTime");
            Property(t => t.AgeRestriction).HasColumnName("AgeRestriction");
            Property(t => t.Genre).HasColumnName("Genre");

            // Relationships
        }
    }
}
