using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StateName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("State");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
