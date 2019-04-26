using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalReviewMap : EntityTypeConfiguration<AppraisalReview>
    {
        public AppraisalReviewMap()
        {
            // Primary Key
            this.HasKey(t => t.AppraisalReviewID);

            // Properties
            this.Property(t => t.ApprParameter)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.score)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("AppraisalReview");
            this.Property(t => t.AppraisalReviewID).HasColumnName("AppraisalReviewID");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.ApprParameter).HasColumnName("ApprParameter");
            this.Property(t => t.ParameterID).HasColumnName("ParameterID");
            this.Property(t => t.score).HasColumnName("score");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.commentBy).HasColumnName("commentBy");
            this.Property(t => t.commentDate).HasColumnName("commentDate");
        }
    }
}
