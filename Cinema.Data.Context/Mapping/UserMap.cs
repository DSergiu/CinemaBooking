namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Domain;

    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.UserGuid);

            // Properties
            Property(t => t.UserGuid).IsRequired();
            Property(t => t.Salt).IsRequired().HasMaxLength(250);
            Property(t => t.Password).IsRequired().HasMaxLength(250);
            Property(t => t.Email).IsRequired()
                .HasMaxLength(200).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
            Property(t => t.Phone).IsRequired()
                .HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            // Table & Column Mappings
            ToTable("User");
            Property(t => t.UserGuid).HasColumnName("UserGuid");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Salt).HasColumnName("Salt");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.LastLogin).HasColumnName("LastLogin");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.Phone).HasColumnName("Phone");
            Property(t => t.AccessLevel).HasColumnName("AccessLevel");

            Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            Property(t => t.UpdatedOn).HasColumnName("UpdatedOn");

            // Relationships
        }
    }
}
