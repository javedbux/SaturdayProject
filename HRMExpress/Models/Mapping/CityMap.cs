using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.CityID);

            // Properties
            this.Property(t => t.CityName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("City");
            this.Property(t => t.CityID).HasColumnName("CityID");
            this.Property(t => t.CityName).HasColumnName("CityName");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
