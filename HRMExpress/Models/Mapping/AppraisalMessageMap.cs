using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class AppraisalMessageMap : EntityTypeConfiguration<AppraisalMessage>
    {
        public AppraisalMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessagesID);

            // Properties
            this.Property(t => t.MessagesText)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.MsgStatus)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AppraisalMessages");
            this.Property(t => t.MessagesID).HasColumnName("MessagesID");
            this.Property(t => t.MessagesText).HasColumnName("MessagesText");
            this.Property(t => t.SentBY).HasColumnName("SentBY");
            this.Property(t => t.SentFor).HasColumnName("SentFor");
            this.Property(t => t.SentDate).HasColumnName("SentDate");
            this.Property(t => t.ReadDate).HasColumnName("ReadDate");
            this.Property(t => t.MsgStatus).HasColumnName("MsgStatus");
        }
    }
}
