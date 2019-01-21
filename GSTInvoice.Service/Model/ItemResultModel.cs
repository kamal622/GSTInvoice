using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service.Model
{
    public class ItemResultModel
    {
        public int id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string UnitOfMeasuement { get; set; }
        public string HSN_SACcode { get; set; }
        public string ItemCode { get; set; }
        public int TaxRate { get; set; }
        public decimal CessAmount { get; set; }
        public string ItemNotes { get; set; }
    }
}
