using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using HRMExpress.Core.Data;
using System.ComponentModel.DataAnnotations.Schema;


namespace HRMExpress.Data.Mapping
{
    public class MenuMasterMap : EntityTypeConfiguration<MenuMaster>
    {
        public MenuMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            this.Property(t => t.ID)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                         
            // Properties
            this.Property(t => t.Code)
            .HasMaxLength(250);

            this.Property(t => t.Name)
            .HasMaxLength(250);

            this.Property(t => t.Description)
            .HasMaxLength(250);

            this.Property(t => t.IsGroup);

            this.Property(t => t.GroupID);

            this.Property(t => t.GroupLevel);

            this.Property(t => t.Active);

            this.Property(t => t.MenuIcon)
                .HasMaxLength(250);
            this.Property(t => t.Sequence);

            this.Property(t => t.ActionURL);


            this.HasKey(t => t.CompanyID);

            this.HasKey(t => t.RoleID);

            // Table & Column Mappings
            this.ToTable("MenuMaster");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsGroup).HasColumnName("IsGroup");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.GroupLevel).HasColumnName("GroupLevel");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.MenuIcon).HasColumnName("MenuIcon");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.ActionURL).HasColumnName("ActionURL");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
        }
    }
}
