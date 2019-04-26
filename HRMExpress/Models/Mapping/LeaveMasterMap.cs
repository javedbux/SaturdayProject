using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class LeaveMasterMap : EntityTypeConfiguration<LeaveMaster>
    {
        public LeaveMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.leavemaster_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("LeaveMaster");
            this.Property(t => t.leavemaster_id).HasColumnName("leavemaster_id");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.leavetype_id).HasColumnName("leavetype_id");
            this.Property(t => t.allottedleaves).HasColumnName("allottedleaves");
            this.Property(t => t.foryear).HasColumnName("foryear");
            this.Property(t => t.crd).HasColumnName("crd");
            this.Property(t => t.isdeleted).HasColumnName("isdeleted");
        }
    }
}
