using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class ReceivedRequirementMap : EntityTypeConfiguration<ReceivedRequirement>
    {
        public ReceivedRequirementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FlowID, t.RequirementID, t.Platforms, t.Technology, t.Experiance, t.DivisionName, t.PerferedSkill, t.JobType, t.Priority, t.PushBy, t.PushTo, t.PushDate });

            // Properties
            this.Property(t => t.FlowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequirementID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Platforms)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Technology)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Experiance)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.DivisionName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.PerferedSkill)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.JobType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Priority)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PushBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PushTo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasMaxLength(10);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ReceivedRequirement");
            this.Property(t => t.FlowID).HasColumnName("FlowID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.Platforms).HasColumnName("Platforms");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.Experiance).HasColumnName("Experiance");
            this.Property(t => t.DivisionName).HasColumnName("DivisionName");
            this.Property(t => t.PerferedSkill).HasColumnName("PerferedSkill");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.PushBy).HasColumnName("PushBy");
            this.Property(t => t.PushTo).HasColumnName("PushTo");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PushDate).HasColumnName("PushDate");
        }
    }
}
