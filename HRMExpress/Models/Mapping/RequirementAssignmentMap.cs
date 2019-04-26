using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RequirementAssignmentMap : EntityTypeConfiguration<RequirementAssignment>
    {
        public RequirementAssignmentMap()
        {
            // Primary Key
            this.HasKey(t => t.AssID);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("RequirementAssignment");
            this.Property(t => t.AssID).HasColumnName("AssID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.AssignedTo).HasColumnName("AssignedTo");
            this.Property(t => t.AssignedBy).HasColumnName("AssignedBy");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
