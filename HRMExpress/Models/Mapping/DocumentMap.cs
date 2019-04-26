using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class DocumentMap : EntityTypeConfiguration<Document>
    {
        public DocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentID);

            // Properties
            this.Property(t => t.DocName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DocPath)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DocumentDetail)
                .IsRequired();

            this.Property(t => t.DocumentType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Document");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.DocName).HasColumnName("DocName");
            this.Property(t => t.DocPath).HasColumnName("DocPath");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.DocumentDetail).HasColumnName("DocumentDetail");
            this.Property(t => t.DocumentType).HasColumnName("DocumentType");
        }
    }
}
