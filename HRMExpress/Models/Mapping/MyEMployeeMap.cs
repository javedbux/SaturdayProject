using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class MyEMployeeMap : EntityTypeConfiguration<MyEMployee>
    {
        public MyEMployeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.Designation, t.ManagerID, t.CorporateEmailID, t.ContactNo, t.DepartmentName, t.ImmigrationStatus, t.Gender, t.MaritalStatus, t.IsDeleted });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(152);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Manager)
                .HasMaxLength(152);

            this.Property(t => t.CorporateEmailID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.DepartmentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmergencyContactName)
                .HasMaxLength(50);

            this.Property(t => t.PersonalEmailID)
                .HasMaxLength(50);

            this.Property(t => t.SSN)
                .HasMaxLength(50);

            this.Property(t => t.ImmigrationStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MyEMployee");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DateOfJoining).HasColumnName("DateOfJoining");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.Manager).HasColumnName("Manager");
            this.Property(t => t.AgeYears).HasColumnName("AgeYears");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.CorporateEmailID).HasColumnName("CorporateEmailID");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.DepartmentName).HasColumnName("DepartmentName");
            this.Property(t => t.EmergencyContactName).HasColumnName("EmergencyContactName");
            this.Property(t => t.EmergencyContactNumber).HasColumnName("EmergencyContactNumber");
            this.Property(t => t.PersonalEmailID).HasColumnName("PersonalEmailID");
            this.Property(t => t.SSN).HasColumnName("SSN");
            this.Property(t => t.ImmigrationStatus).HasColumnName("ImmigrationStatus");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
