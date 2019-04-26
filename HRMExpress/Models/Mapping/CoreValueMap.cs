using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class CoreValueMap : EntityTypeConfiguration<CoreValue>
    {
        public CoreValueMap()
        {
            // Primary Key
            this.HasKey(t => t.CoreValueID);

            // Properties
            this.Property(t => t.CoreValueDescription)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CoreValues");
            this.Property(t => t.CoreValueID).HasColumnName("CoreValueID");
            this.Property(t => t.CoreValueDescription).HasColumnName("CoreValueDescription");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.AppraisalTemplateID).HasColumnName("AppraisalTemplateID");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.AppraisalTemplate)
                .WithMany(t => t.CoreValues)
                .HasForeignKey(d => d.AppraisalTemplateID);

        }
    }
}
