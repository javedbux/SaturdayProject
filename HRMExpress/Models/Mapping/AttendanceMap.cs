using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AttendanceMap : EntityTypeConfiguration<Attendance>
    {
        public AttendanceMap()
        {
            // Primary Key
            this.HasKey(t => t.aid);

            // Properties
            this.Property(t => t.remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Attendance");
            this.Property(t => t.aid).HasColumnName("aid");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.logout).HasColumnName("logout");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.adate).HasColumnName("adate");
        }
    }
}
