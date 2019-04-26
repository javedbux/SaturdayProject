using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuID);

            // Properties
            this.Property(t => t.UI_sref)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuLevel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MainMenu)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Menu");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.EmployeeRoleID).HasColumnName("EmployeeRoleID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.UI_sref).HasColumnName("UI_sref");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.MenuLevel).HasColumnName("MenuLevel");
            this.Property(t => t.MainMenu).HasColumnName("MainMenu");
        }
    }
}
