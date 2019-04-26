using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class LeaveTransactionMap : EntityTypeConfiguration<LeaveTransaction>
    {
        public LeaveTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.leavetran_id);

            // Properties
            this.Property(t => t.proofname)
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(500);

            this.Property(t => t.remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LeaveTransaction");
            this.Property(t => t.leavetran_id).HasColumnName("leavetran_id");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.leave_type_id).HasColumnName("leave_type_id");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.end_date).HasColumnName("end_date");
            this.Property(t => t.ishalfday).HasColumnName("ishalfday");
            this.Property(t => t.proofname).HasColumnName("proofname");
            this.Property(t => t.submit_date).HasColumnName("submit_date");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.isapproved).HasColumnName("isapproved");
            this.Property(t => t.isrejected).HasColumnName("isrejected");
            this.Property(t => t.iscancelled).HasColumnName("iscancelled");
            this.Property(t => t.approvedby).HasColumnName("approvedby");
            this.Property(t => t.approve_date).HasColumnName("approve_date");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
