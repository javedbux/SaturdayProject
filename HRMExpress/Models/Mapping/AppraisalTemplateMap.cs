using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalTemplateMap : EntityTypeConfiguration<AppraisalTemplate>
    {
        public AppraisalTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.AppraisalTemplateId);

            // Properties
            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AppraisalTemplate");
            this.Property(t => t.AppraisalTemplateId).HasColumnName("AppraisalTemplateId");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
