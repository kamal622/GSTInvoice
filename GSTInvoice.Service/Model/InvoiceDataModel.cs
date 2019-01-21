using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service.Model
{
    public class InvoiceDataModel
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxableValue { get; set; }
        public string TaxableRate { get; set; }
        public string UnitOfMeasurement { get; set; }
        public decimal TaxValue { get; set; }
        public int Percentage { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatDate { get; set; }
        public int CreatBy { get; set; }
    }
}
