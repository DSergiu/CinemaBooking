namespace Cinema.Data.Context.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    
    public class LoginTokenMap : EntityTypeConfiguration<LoginToken>
    {
        public LoginTokenMap()
        {
            // Primary Key
            HasKey(t => t.TokenKey);

            // Properties
            Property(t => t.TokenKey).IsRequired();
            Property(t => t.UserGuid).IsRequired();
            Property(t => t.TokenExpiration).IsRequired();

            // Table & Column Mappings
            ToTable("LoginToken");
            Property(t => t.TokenKey).HasColumnName("TokenKey");
            Property(t => t.UserGuid).HasColumnName("UserGuid");
            Property(t => t.TokenExpiration).HasColumnName("TokenExpiration");

            // Relationships
            HasRequired(t => t.User).WithMany(t => t.LoginToken).HasForeignKey(d => d.UserGuid);
        }
    }
}
