using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
   public class CityService
    {
        public Data.Models.City[] GetCityList(int stateId)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.Cities.Where(w => w.StateId == stateId).OrderBy(o => o.CityName).ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
