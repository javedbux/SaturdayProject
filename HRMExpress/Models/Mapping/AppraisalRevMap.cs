using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalRevMap : EntityTypeConfiguration<AppraisalRev>
    {
        public AppraisalRevMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AppraisalReviewID, t.AppraisalID, t.TemplateName, t.ApprParameter, t.CoreValueDescription, t.ParameterID, t.score, t.DateOfCompletion, t.comment, t.commentBy, t.commentDate });

            // Properties
            this.Property(t => t.AppraisalReviewID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AppraisalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApprParameter)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CoreValueDescription)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParameterID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.score)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.commentBy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AppraisalRev");
            this.Property(t => t.AppraisalReviewID).HasColumnName("AppraisalReviewID");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.ApprParameter).HasColumnName("ApprParameter");
            this.Property(t => t.CoreValueDescription).HasColumnName("CoreValueDescription");
            this.Property(t => t.ParameterID).HasColumnName("ParameterID");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.DateOfCompletion).HasColumnName("DateOfCompletion");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.commentBy).HasColumnName("commentBy");
            this.Property(t => t.commentDate).HasColumnName("commentDate");
        }
    }
}
