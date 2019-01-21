using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class UnitOfMeasurementMap : EntityTypeConfiguration<UnitOfMeasurement>
    {
        public UnitOfMeasurementMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UnitOfMeasurementType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UnitOfMeasurement");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UnitOfMeasurementType).HasColumnName("UnitOfMeasurementType");
        }
    }
}
