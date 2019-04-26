using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class TrainingDetailMap : EntityTypeConfiguration<TrainingDetail>
    {
        public TrainingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.TrainingID);

            // Properties
            this.Property(t => t.StartTime)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.EndTime)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Objectives)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeFeedback)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SupervisorFeedback)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TrainerFeedback)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TrainingDetails");
            this.Property(t => t.TrainingID).HasColumnName("TrainingID");
            this.Property(t => t.CandidateID).HasColumnName("CandidateID");
            this.Property(t => t.TrainerID).HasColumnName("TrainerID");
            this.Property(t => t.SupervisorID).HasColumnName("SupervisorID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Objectives).HasColumnName("Objectives");
            this.Property(t => t.EmployeeFeedback).HasColumnName("EmployeeFeedback");
            this.Property(t => t.SupervisorFeedback).HasColumnName("SupervisorFeedback");
            this.Property(t => t.TrainerFeedback).HasColumnName("TrainerFeedback");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
