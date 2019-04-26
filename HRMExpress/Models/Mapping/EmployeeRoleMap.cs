using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class EmployeeRoleMap : EntityTypeConfiguration<EmployeeRole>
    {
        public EmployeeRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.EmpRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmployeeRole");
            this.Property(t => t.EmpRoleID).HasColumnName("EmpRoleID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.CrDateTime).HasColumnName("CrDateTime");
        }
    }
}
