using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.Line1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Line2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zipcode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AddressType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Address");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.Line1).HasColumnName("Line1");
            this.Property(t => t.Line2).HasColumnName("Line2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zipcode).HasColumnName("Zipcode");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.AddressType).HasColumnName("AddressType");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
        }
    }
}
