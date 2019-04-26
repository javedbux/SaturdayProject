using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class EmployeeDocumentMap : EntityTypeConfiguration<EmployeeDocument>
    {
        public EmployeeDocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.DocID);

            // Properties
            this.Property(t => t.DocName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Documnet)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("EmployeeDocuments");
            this.Property(t => t.DocID).HasColumnName("DocID");
            this.Property(t => t.DocName).HasColumnName("DocName");
            this.Property(t => t.Documnet).HasColumnName("Documnet");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.UploadDate).HasColumnName("UploadDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
