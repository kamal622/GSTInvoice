using System;

namespace GSTInvoice.App.Model
{
    public class TaxInvoice
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int BankId { get; set; }
        public string SerialNumber { get; set; }
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string Gstin { get; set; }
        public string PlaceOfSupply { get; set; }
        public string CustomerNotes { get; set; }
        public string TermsAndConditions { get; set; }
        public DateTime CreatDate { get; set; }
        public int CreatBy { get; set; }
    }
}
