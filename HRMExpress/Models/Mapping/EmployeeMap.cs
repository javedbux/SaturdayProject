using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CorporateEmailID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonalEmailID)
                .HasMaxLength(50);

            this.Property(t => t.ContactNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.EmergencyContactName)
                .HasMaxLength(50);

            this.Property(t => t.SSN)
                .HasMaxLength(50);

            this.Property(t => t.ImmigrationStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.DateOfJoining).HasColumnName("DateOfJoining");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.CorporateEmailID).HasColumnName("CorporateEmailID");
            this.Property(t => t.PersonalEmailID).HasColumnName("PersonalEmailID");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.EmergencyContactName).HasColumnName("EmergencyContactName");
            this.Property(t => t.EmergencyContactNumber).HasColumnName("EmergencyContactNumber");
            this.Property(t => t.SSN).HasColumnName("SSN");
            this.Property(t => t.ImmigrationStatus).HasColumnName("ImmigrationStatus");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.DepartmentID);

        }
    }
}
