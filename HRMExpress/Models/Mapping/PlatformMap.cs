using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class PlatformMap : EntityTypeConfiguration<Platform>
    {
        public PlatformMap()
        {
            // Primary Key
            this.HasKey(t => t.PlatformID);

            // Properties
            this.Property(t => t.PlatformDesc)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Platforms");
            this.Property(t => t.PlatformID).HasColumnName("PlatformID");
            this.Property(t => t.PlatformDesc).HasColumnName("PlatformDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
