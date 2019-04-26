using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace HRMExpress.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateID);

            // Properties
            this.Property(t => t.SateName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("State");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.SateName).HasColumnName("SateName");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
