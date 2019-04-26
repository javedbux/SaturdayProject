using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class JobTypeMap : EntityTypeConfiguration<JobType>
    {
        public JobTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.JobTypeID);

            // Properties
            this.Property(t => t.JobType1)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("JobType");
            this.Property(t => t.JobTypeID).HasColumnName("JobTypeID");
            this.Property(t => t.JobType1).HasColumnName("JobType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
