namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;    
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Domain;
    
    public class HallMap : EntityTypeConfiguration<Hall>
    {
        public HallMap()
        {
            // Primary Key
            HasKey(t => t.HallId);

            // Properties
            Property(t => t.HallName).IsRequired().HasMaxLength(50)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute(){IsUnique = true}));

            // Table & Column Mappings
            ToTable("Hall");
            Property(t => t.HallId).HasColumnName("HallId");
            Property(t => t.HallName).HasColumnName("HallName");

            // Relationships
        }
    }
}
