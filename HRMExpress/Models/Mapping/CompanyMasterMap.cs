using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class CompanyMasterMap : EntityTypeConfiguration<CompanyMaster>
    {
        public CompanyMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyID);

            // Properties
            this.Property(t => t.CompanyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(250);

            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.Email)
                .HasMaxLength(250);

            this.Property(t => t.Website)
                .HasMaxLength(250);

            this.Property(t => t.ContactPerson)
                .HasMaxLength(250);

            this.Property(t => t.ContactNo)
                .HasMaxLength(250);

            this.Property(t => t.AlternateNo)
                .HasMaxLength(250);

            this.Property(t => t.Address)
                .HasMaxLength(250);

            this.Property(t => t.City)
                .HasMaxLength(250);

            this.Property(t => t.State)
                .HasMaxLength(250);

            this.Property(t => t.Country)
                .HasMaxLength(250);

            this.Property(t => t.PageTitle)
                .HasMaxLength(250);

            this.Property(t => t.PageLogo)
                .HasMaxLength(250);

            this.Property(t => t.HRMPlan)
                .HasMaxLength(250);

            this.Property(t => t.PaymentType)
                .HasMaxLength(250);

            this.Property(t => t.PaymentStatus)
                .HasMaxLength(250);

            this.Property(t => t.UserName)
                .HasMaxLength(250);

            this.Property(t => t.Password)
                .HasMaxLength(250);

            this.Property(t => t.PasswordSalt)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CompanyMaster");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.AlternateNo).HasColumnName("AlternateNo");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.PageTitle).HasColumnName("PageTitle");
            this.Property(t => t.PageLogo).HasColumnName("PageLogo");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.HRMPlan).HasColumnName("HRMPlan");
            this.Property(t => t.PaymentType).HasColumnName("PaymentType");
            this.Property(t => t.PaymentStatus).HasColumnName("PaymentStatus");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.PasswordSalt).HasColumnName("PasswordSalt");
            this.Property(t => t.LastLoginDate).HasColumnName("LastLoginDate");
            this.Property(t => t.CanEdit).HasColumnName("CanEdit");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
