using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class ExperianceMap : EntityTypeConfiguration<Experiance>
    {
        public ExperianceMap()
        {
            // Primary Key
            this.HasKey(t => t.ExperianceID);

            // Properties
            this.Property(t => t.ExperianceDesc)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Experiance");
            this.Property(t => t.ExperianceID).HasColumnName("ExperianceID");
            this.Property(t => t.ExperianceDesc).HasColumnName("ExperianceDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
