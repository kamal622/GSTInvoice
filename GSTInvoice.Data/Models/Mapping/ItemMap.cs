using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GSTInvoice.Data.Models.Mapping
{
    public class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.UnitOfMeasuement)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.HSN_SACcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Item");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.UnitOfMeasuement).HasColumnName("UnitOfMeasuement");
            this.Property(t => t.HSN_SACcode).HasColumnName("HSN_SACcode");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.CessAmount).HasColumnName("CessAmount");
            this.Property(t => t.ItemNotes).HasColumnName("ItemNotes");
            this.Property(t => t.CreatDate).HasColumnName("CreatDate");
            this.Property(t => t.CreatBy).HasColumnName("CreatBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.DeleteDate).HasColumnName("DeleteDate");
            this.Property(t => t.DeleteBy).HasColumnName("DeleteBy");
        }
    }
}
