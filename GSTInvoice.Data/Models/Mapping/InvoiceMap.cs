using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SerialNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Reference)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.BillingAddress)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ShippingAddress)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.GSTIN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlaceOfSupply)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CustomerNotes)
                .IsRequired();

            this.Property(t => t.TermsAndConditions)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Invoice");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.BankId).HasColumnName("BankId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(t => t.Reference).HasColumnName("Reference");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.BillingAddress).HasColumnName("BillingAddress");
            this.Property(t => t.ShippingAddress).HasColumnName("ShippingAddress");
            this.Property(t => t.GSTIN).HasColumnName("GSTIN");
            this.Property(t => t.PlaceOfSupply).HasColumnName("PlaceOfSupply");
            this.Property(t => t.CustomerNotes).HasColumnName("CustomerNotes");
            this.Property(t => t.TermsAndConditions).HasColumnName("TermsAndConditions");
            this.Property(t => t.CreatDate).HasColumnName("CreatDate");
            this.Property(t => t.CreatBy).HasColumnName("CreatBy");

            // Relationships
            this.HasRequired(t => t.Account)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.AccountId);
            this.HasRequired(t => t.AccountBankDetail)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.BankId);

        }
    }
}
