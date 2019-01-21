using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class TaxableRateService
    {
        public Data.Models.TaxableRate[] GetTaxableRate()
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.TaxableRates.OrderBy(o => o.TaxableRate1).ToArray();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
