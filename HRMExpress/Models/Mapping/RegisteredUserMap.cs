using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RegisteredUserMap : EntityTypeConfiguration<RegisteredUser>
    {
        public RegisteredUserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmpRoleID, t.EmployeeID, t.UserName, t.Employee, t.Password, t.RoleID, t.Role, t.IsActive });

            // Properties
            this.Property(t => t.EmpRoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Employee)
                .IsRequired()
                .HasMaxLength(101);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Role)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RegisteredUsers");
            this.Property(t => t.EmpRoleID).HasColumnName("EmpRoleID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Employee).HasColumnName("Employee");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.Role).HasColumnName("Role");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
