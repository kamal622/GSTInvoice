using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class InvoiceTransaction
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxableValue { get; set; }
        public decimal TaxableRate { get; set; }
        public decimal TaxValue { get; set; }
        public int Percentage { get; set; }
        public decimal Total { get; set; }
        public System.DateTime CreatDate { get; set; }
        public int CreatBy { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Item Item { get; set; }
    }
}
