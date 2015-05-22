namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Domain;
    
    public class TicketTypeMap : EntityTypeConfiguration<TicketType>
    {
        public TicketTypeMap()
        {
            // Primary Key
            HasKey(t => t.TicketTypeId);

            // Properties
            Property(t => t.Type).IsRequired().HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
            Property(t => t.Discount).IsRequired();

            // Table & Column Mappings
            ToTable("TicketType");
            Property(t => t.TicketTypeId).HasColumnName("TicketTypeId");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.Discount).HasColumnName("Discount");

            // Relationships
        }
    }
}
