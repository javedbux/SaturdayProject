using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using HRMExpress.Core.Data;


namespace HRMExpress.Data.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(500);

            this.HasKey(t => t.CompanyID);

            this.HasKey(t => t.RoleID);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LastLogin).HasColumnName("LastLogin");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
        }
    }
}
