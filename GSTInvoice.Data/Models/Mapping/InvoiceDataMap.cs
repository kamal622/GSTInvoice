using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class InvoiceDataMap : EntityTypeConfiguration<InvoiceTransaction>
    {
        public InvoiceDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Qty)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Rate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Discount)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TaxableValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TaxableRate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TxtValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parsantage)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Total)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InvoiceData");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.TaxableValue).HasColumnName("TaxableValue");
            this.Property(t => t.TaxableRate).HasColumnName("TaxableRate");
            this.Property(t => t.TxtValue).HasColumnName("TxtValue");
            this.Property(t => t.Parsantage).HasColumnName("Parsantage");
            this.Property(t => t.Total).HasColumnName("Total");

           

        }
    }
}
