using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class InterviewMap : EntityTypeConfiguration<Interview>
    {
        public InterviewMap()
        {
            // Primary Key
            this.HasKey(t => t.InterviewID);

            // Properties
            this.Property(t => t.Outcome)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Interview");
            this.Property(t => t.InterviewID).HasColumnName("InterviewID");
            this.Property(t => t.CandidateID).HasColumnName("CandidateID");
            this.Property(t => t.InterviewerID).HasColumnName("InterviewerID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.InterviewDateTime).HasColumnName("InterviewDateTime");
            this.Property(t => t.Outcome).HasColumnName("Outcome");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
