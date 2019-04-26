using System;
using System.Data.Entity.ModelConfiguration;
using HRMExpress.Core.Data;

namespace HRMExpress.Data.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmentID);

            // Properties
            this.Property(t => t.DepartmentName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Department");
            //this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            //this.Property(t => t.DepartmentName).HasColumnName("DepartmentName");
            //this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            //HasRequired(t => t.Employees).WithRequiredDependent(u => u.Department);
            //HasRequired(t => t.Employees).WithMany(c => c.Department).HasForeignKey
            //       (t => t.DepartmentID).WillCascadeOnDelete(false);  
        }
    }
}
