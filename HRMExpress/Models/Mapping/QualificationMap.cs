using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class QualificationMap : EntityTypeConfiguration<Qualification>
    {
        public QualificationMap()
        {
            // Primary Key
            this.HasKey(t => t.QualificationID);

            // Properties
            this.Property(t => t.QualificationDesc)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Qualification");
            this.Property(t => t.QualificationID).HasColumnName("QualificationID");
            this.Property(t => t.QualificationDesc).HasColumnName("QualificationDesc");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
