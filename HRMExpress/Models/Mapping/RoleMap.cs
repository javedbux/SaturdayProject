using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Role1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Roles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Role1).HasColumnName("Role");
            this.Property(t => t.Isdeleted).HasColumnName("Isdeleted");
        }
    }
}
