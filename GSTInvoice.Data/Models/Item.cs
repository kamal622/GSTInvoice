using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class Item
    {
        public Item()
        {
            this.InvoiceTransactions = new List<InvoiceTransaction>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string UnitOfMeasuement { get; set; }
        public string HSN_SACcode { get; set; }
        public string ItemCode { get; set; }
        public int TaxRate { get; set; }
        public Nullable<decimal> CessAmount { get; set; }
        public string ItemNotes { get; set; }
        public System.DateTime CreatDate { get; set; }
        public int CreatBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public virtual ICollection<InvoiceTransaction> InvoiceTransactions { get; set; }
    }
}
