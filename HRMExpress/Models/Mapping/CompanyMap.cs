using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyID);

            // Properties
            this.Property(t => t.companyname)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.TaxID)
                .HasMaxLength(50);

            this.Property(t => t.NAICS)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.FAX)
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Address2)
                .HasMaxLength(250);

            this.Property(t => t.country)
                .HasMaxLength(150);

            this.Property(t => t.city)
                .HasMaxLength(150);

            this.Property(t => t.state)
                .HasMaxLength(150);

            this.Property(t => t.zipcode)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Company");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.companyname).HasColumnName("companyname");
            this.Property(t => t.NumberofEmployees).HasColumnName("NumberofEmployees");
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.NAICS).HasColumnName("NAICS");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.FAX).HasColumnName("FAX");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zipcode).HasColumnName("zipcode");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
