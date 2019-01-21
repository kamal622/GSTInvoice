using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            this.InvoiceTransactions = new List<InvoiceTransaction>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public int CustomerId { get; set; }
        public string SerialNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string Reference { get; set; }
        public System.DateTime DueDate { get; set; }
        public string CustomerName { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string GSTIN { get; set; }
        public string PlaceOfSupply { get; set; }
        public string CustomerNotes { get; set; }
        public string TermsAndConditions { get; set; }
        public System.DateTime CreatDate { get; set; }
        public int CreatBy { get; set; }
        public virtual Account Account { get; set; }
        public virtual AccountBankDetail AccountBankDetail { get; set; }
        public virtual ICollection<InvoiceTransaction> InvoiceTransactions { get; set; }
    }
}
