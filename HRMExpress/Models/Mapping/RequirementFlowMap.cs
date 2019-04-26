using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RequirementFlowMap : EntityTypeConfiguration<RequirementFlow>
    {
        public RequirementFlowMap()
        {
            // Primary Key
            this.HasKey(t => t.FlowID);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("RequirementFlow");
            this.Property(t => t.FlowID).HasColumnName("FlowID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.PushBy).HasColumnName("PushBy");
            this.Property(t => t.PushTo).HasColumnName("PushTo");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PushDate).HasColumnName("PushDate");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
