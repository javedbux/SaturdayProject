using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalMap : EntityTypeConfiguration<Appraisal>
    {
        public AppraisalMap()
        {
            // Primary Key
            this.HasKey(t => t.AppraisalID);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Appraisal");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.AppraisalTemplateID).HasColumnName("AppraisalTemplateID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.AssignedBy).HasColumnName("AssignedBy");
            this.Property(t => t.AssignedDate).HasColumnName("AssignedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.DateofCompleted).HasColumnName("DateofCompleted");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.AppraisalTemplate)
                .WithMany(t => t.Appraisals)
                .HasForeignKey(d => d.AppraisalTemplateID);

        }
    }
}
