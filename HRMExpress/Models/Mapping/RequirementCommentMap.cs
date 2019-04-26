using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class RequirementCommentMap : EntityTypeConfiguration<RequirementComment>
    {
        public RequirementCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentID);

            // Properties
            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("RequirementComment");
            this.Property(t => t.CommentID).HasColumnName("CommentID");
            this.Property(t => t.RequirementID).HasColumnName("RequirementID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CommentBy).HasColumnName("CommentBy");
            this.Property(t => t.CommentTo).HasColumnName("CommentTo");
            this.Property(t => t.CommentDate).HasColumnName("CommentDate");
        }
    }
}
