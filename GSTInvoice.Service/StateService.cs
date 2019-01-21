using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class StateService
    {
        public Data.Models.State[] GetStateList()
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.States.OrderBy(o => o.StateName).ToArray();
                }
            }
            catch 
            {
                throw;
            }
        }

        public Data.Models.State GetStateById(int Id)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.States.FirstOrDefault(o => o.Id == Id);
                }
            }
            catch 
            {
                throw;
            }
        }

    }
}
