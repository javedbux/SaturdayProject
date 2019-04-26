using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RequirementMap : EntityTypeConfiguration<Requirement>
    {
        public RequirementMap()
        {
            // Primary Key
            this.HasKey(t => t.RequirementID);

            // Properties
            this.Property(t => t.JobDescription)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Platforms)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Technology)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Qualifications)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Experiance)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.PerferedSkill)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.JobType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Priority)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cirtification)
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Requirement");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.Platforms).HasColumnName("Platforms");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.Qualifications).HasColumnName("Qualifications");
            this.Property(t => t.Experiance).HasColumnName("Experiance");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.CityID).HasColumnName("CityID");
            this.Property(t => t.PerferedSkill).HasColumnName("PerferedSkill");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Cirtification).HasColumnName("Cirtification");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
