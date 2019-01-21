using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class AccountBankDetailService
    {
        public List<Data.Models.AccountBankDetail> GetAccountBankList(int accountId)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.AccountBankDetails.Where(w => w.AccountId == accountId).OrderBy(o => o.BankName).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Data.Models.AccountBankDetail GetBankDataById(int accountId)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.AccountBankDetails.FirstOrDefault(w => w.Id == accountId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
