using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RequirementDetails_tMap : EntityTypeConfiguration<RequirementDetails_t>
    {
        public RequirementDetails_tMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RequirementID, t.JobDescription, t.Platforms, t.Technology, t.Experiance, t.Qualifications, t.DivisionID, t.DivisionName, t.CountryID, t.CountryName, t.StateID, t.SateName, t.CityID, t.CityName, t.PerferedSkill, t.JobType, t.Priority, t.CreateDate, t.CreatedBy, t.IsDeleted });

            // Properties
            this.Property(t => t.RequirementID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JobDescription)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Platforms)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Technology)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Experiance)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Qualifications)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.DivisionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DivisionName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.CountryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SateName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.CityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CityName)
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

            this.Property(t => t.CreatedBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("RequirementDetails_t");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.Platforms).HasColumnName("Platforms");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.Experiance).HasColumnName("Experiance");
            this.Property(t => t.Qualifications).HasColumnName("Qualifications");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.DivisionName).HasColumnName("DivisionName");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.SateName).HasColumnName("SateName");
            this.Property(t => t.CityID).HasColumnName("CityID");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.PerferedSkill).HasColumnName("PerferedSkill");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.Cirtification).HasColumnName("Cirtification");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
