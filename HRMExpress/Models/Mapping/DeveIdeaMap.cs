using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class DeveIdeaMap : EntityTypeConfiguration<DeveIdea>
    {
        public DeveIdeaMap()
        {
            // Primary Key
            this.HasKey(t => t.DeveIdeaID);

            // Properties
            this.Property(t => t.ApprParameter)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("DeveIdea");
            this.Property(t => t.DeveIdeaID).HasColumnName("DeveIdeaID");
            this.Property(t => t.AppraisalID).HasColumnName("AppraisalID");
            this.Property(t => t.ApprParameter).HasColumnName("ApprParameter");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.commentBy).HasColumnName("commentBy");
            this.Property(t => t.commentDate).HasColumnName("commentDate");
        }
    }
}
