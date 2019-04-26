using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class LeaveTypeMap : EntityTypeConfiguration<LeaveType>
    {
        public LeaveTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.leave_type_id);

            // Properties
            this.Property(t => t.leave_name)
                .HasMaxLength(50);

            this.Property(t => t.leave_description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LeaveType");
            this.Property(t => t.leave_type_id).HasColumnName("leave_type_id");
            this.Property(t => t.leave_name).HasColumnName("leave_name");
            this.Property(t => t.leave_description).HasColumnName("leave_description");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
