using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class AccountBankDetailMap : EntityTypeConfiguration<AccountBankDetail>
    {
        public AccountBankDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BankName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.AccountNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BranchName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.IFSCcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountBankDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.BranchName).HasColumnName("BranchName");
            this.Property(t => t.IFSCcode).HasColumnName("IFSCcode");

            // Relationships
            this.HasRequired(t => t.Account)
                .WithMany(t => t.AccountBankDetails)
                .HasForeignKey(d => d.AccountId);

        }
    }
}
