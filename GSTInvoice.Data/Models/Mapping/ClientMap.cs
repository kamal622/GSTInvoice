using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.BusinessName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.GSTIN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PAN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MobileNo)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Address2)
                .HasMaxLength(500);

            this.Property(t => t.Pincode)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.BusinessName).HasColumnName("BusinessName");
            this.Property(t => t.GSTIN).HasColumnName("GSTIN");
            this.Property(t => t.PAN).HasColumnName("PAN");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.MobileNo).HasColumnName("MobileNo");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.CityId).HasColumnName("CityId");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Pincode).HasColumnName("Pincode");
            this.Property(t => t.CreatDate).HasColumnName("CreatDate");
            this.Property(t => t.CreatBy).HasColumnName("CreatBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.DeleteDate).HasColumnName("DeleteDate");
            this.Property(t => t.DeleteBy).HasColumnName("DeleteBy");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
