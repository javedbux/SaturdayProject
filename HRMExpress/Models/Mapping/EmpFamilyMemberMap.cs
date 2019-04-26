using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class EmpFamilyMemberMap : EntityTypeConfiguration<EmpFamilyMember>
    {
        public EmpFamilyMemberMap()
        {
            // Primary Key
            this.HasKey(t => t.MemberID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Relation)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmpFamilyMember");
            this.Property(t => t.MemberID).HasColumnName("MemberID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Relation).HasColumnName("Relation");
        }
    }
}
