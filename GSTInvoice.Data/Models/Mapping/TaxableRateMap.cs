using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class TaxableRateMap : EntityTypeConfiguration<TaxableRate>
    {
        public TaxableRateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TaxableRate");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TaxableRate1).HasColumnName("TaxableRate");
        }
    }
}
