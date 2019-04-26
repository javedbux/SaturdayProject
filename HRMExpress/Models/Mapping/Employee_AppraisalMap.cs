using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class Employee_AppraisalMap : EntityTypeConfiguration<Employee_Appraisal>
    {
        public Employee_AppraisalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AppraisalID, t.AppraisalTemplateID, t.TemplateName, t.EmployeeID, t.EName, t.Designation, t.ManagerID, t.AssignedBy, t.AssignedDate });

            // Properties
            this.Property(t => t.AppraisalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AppraisalTemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EName)
                .IsRequired()
                .HasMaxLength(101);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignedBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employee_Appraisal");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.AppraisalTemplateID).HasColumnName("AppraisalTemplateID");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.EName).HasColumnName("EName");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.AssignedBy).HasColumnName("AssignedBy");
            this.Property(t => t.AssignedDate).HasColumnName("AssignedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.DateofCompleted).HasColumnName("DateofCompleted");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
