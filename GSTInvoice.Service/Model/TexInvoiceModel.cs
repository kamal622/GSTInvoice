using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service.Model
{
    public class TexInvoiceModel
    {
        public int IGST { get; set; }
        public int CGST { get; set; }
        public int SGST { get; set; }
        public string UnitOfMeasuement { get; set; }
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string HSN_SACcode { get; set; }
        public string ItemCode { get; set; }
        public int Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxableValue { get; set; }
        public decimal TaxableRate { get; set; }
        public decimal TaxValue { get; set; }
        public int Percentage { get; set; }
    }
}
