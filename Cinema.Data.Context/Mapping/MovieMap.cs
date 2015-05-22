namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            // Primary Key
            HasKey(t => t.MovieId);

            // Properties
            Property(t => t.MovieInfoId).IsRequired();
            Property(t => t.Is3D).IsRequired();

            // Table & Column Mappings
            ToTable("Movie");
            Property(t => t.MovieId).HasColumnName("MovieId");
            Property(t => t.MovieInfoId).HasColumnName("MovieInfoId");
            Property(t => t.Is3D).HasColumnName("Is3D");

            // Relationships
            HasRequired(t => t.MovieInfo).WithMany(t => t.Movies).HasForeignKey(d => d.MovieInfoId);
        }
    }
}
