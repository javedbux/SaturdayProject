using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class CandidateMap : EntityTypeConfiguration<Candidate>
    {
        public CandidateMap()
        {
            // Primary Key
            this.HasKey(t => t.CandidateID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

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

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PersonalEmailID)
                .HasMaxLength(50);

            this.Property(t => t.ContactNo)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Candidate");
            this.Property(t => t.CandidateID).HasColumnName("CandidateID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.Line1).HasColumnName("Line1");
            this.Property(t => t.Line2).HasColumnName("Line2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zipcode).HasColumnName("Zipcode");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.DateOfInterview).HasColumnName("DateOfInterview");
            this.Property(t => t.InterViewerID).HasColumnName("InterViewerID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.PersonalEmailID).HasColumnName("PersonalEmailID");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany(t => t.Candidates)
                .HasForeignKey(d => d.DepartmentID);

        }
    }
}
