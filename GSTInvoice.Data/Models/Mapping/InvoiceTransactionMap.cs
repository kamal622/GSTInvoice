using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class InvoiceTransactionMap : EntityTypeConfiguration<InvoiceTransaction>
    {
        public InvoiceTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("InvoiceTransactions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvoiceId).HasColumnName("InvoiceId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.TaxableValue).HasColumnName("TaxableValue");
            this.Property(t => t.TaxableRate).HasColumnName("TaxableRate");
            this.Property(t => t.TaxValue).HasColumnName("TaxValue");
            this.Property(t => t.Percentage).HasColumnName("Percentage");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CreatDate).HasColumnName("CreatDate");
            this.Property(t => t.CreatBy).HasColumnName("CreatBy");

            // Relationships
            this.HasRequired(t => t.Invoice)
                .WithMany(t => t.InvoiceTransactions)
                .HasForeignKey(d => d.InvoiceId);
            this.HasRequired(t => t.Item)
                .WithMany(t => t.InvoiceTransactions)
                .HasForeignKey(d => d.ItemId);

        }
    }
}
