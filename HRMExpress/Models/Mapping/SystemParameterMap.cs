using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class SystemParameterMap : EntityTypeConfiguration<SystemParameter>
    {
        public SystemParameterMap()
        {
            // Primary Key
            this.HasKey(t => t.ParameterID);

            // Properties
            this.Property(t => t.ParameterName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ParameterValue)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("SystemParameters");
            this.Property(t => t.ParameterID).HasColumnName("ParameterID");
            this.Property(t => t.ParameterName).HasColumnName("ParameterName");
            this.Property(t => t.ParameterValue).HasColumnName("ParameterValue");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
