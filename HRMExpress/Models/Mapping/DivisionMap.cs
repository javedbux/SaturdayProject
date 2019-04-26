using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class DivisionMap : EntityTypeConfiguration<Division>
    {
        public DivisionMap()
        {
            // Primary Key
            this.HasKey(t => t.DivisionID);

            // Properties
            this.Property(t => t.DivisionName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Division");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.DivisionName).HasColumnName("DivisionName");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
