using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalDetailMap : EntityTypeConfiguration<AppraisalDetail>
    {
        public AppraisalDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AppraisalID, t.EmployeeID, t.Designation, t.TemplateName, t.AssignedDate, t.IsDeleted });

            // Properties
            this.Property(t => t.AppraisalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NAME)
                .HasMaxLength(152);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AppraisalDetails");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.AssignedDate).HasColumnName("AssignedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.DateofCompleted).HasColumnName("DateofCompleted");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
