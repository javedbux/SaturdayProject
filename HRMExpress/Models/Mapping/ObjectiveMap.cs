using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class ObjectiveMap : EntityTypeConfiguration<Objective>
    {
        public ObjectiveMap()
        {
            // Primary Key
            this.HasKey(t => t.ObjectiveID);

            // Properties
            this.Property(t => t.ObjectiveDescription)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ObjectiveType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Objectives");
            this.Property(t => t.ObjectiveID).HasColumnName("ObjectiveID");
            this.Property(t => t.ObjectiveDescription).HasColumnName("ObjectiveDescription");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.AppraisalTemplateID).HasColumnName("AppraisalTemplateID");
            this.Property(t => t.DateOfCompletion).HasColumnName("DateOfCompletion");
            this.Property(t => t.ObjectiveType).HasColumnName("ObjectiveType");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.AppraisalTemplate)
                .WithMany(t => t.Objectives)
                .HasForeignKey(d => d.AppraisalTemplateID);

        }
    }
}
