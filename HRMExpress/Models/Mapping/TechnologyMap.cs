using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class TechnologyMap : EntityTypeConfiguration<Technology>
    {
        public TechnologyMap()
        {
            // Primary Key
            this.HasKey(t => t.TechnologyID);

            // Properties
            this.Property(t => t.TechnologyDesc)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Technology");
            this.Property(t => t.TechnologyID).HasColumnName("TechnologyID");
            this.Property(t => t.TechnologyDesc).HasColumnName("TechnologyDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IdDeleted).HasColumnName("IdDeleted");
        }
    }
}
