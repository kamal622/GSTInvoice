using GSTInvoice.Service.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class CommanService
    {
        public Array GetData(string Qry, string tblName)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    if (tblName == "Account")
                    {
                        return db.Database.SqlQuery<AccountResultModel>(Qry).ToArray();
                    }
                    else if (tblName == "Client")
                    {
                        return db.Database.SqlQuery<ClientResultModel>(Qry).ToArray();
                    }
                    else if (tblName == "Item")
                    {
                        return db.Database.SqlQuery<ItemResultModel>(Qry).ToArray();
                    }
                    else if (tblName == "Invoice")
                    {
                        return db.Database.SqlQuery<InvoiceModel>(Qry).ToArray();
                    }
                    else if (tblName == "InvoiceTransactions")
                    {
                        return db.Database.SqlQuery<InvoiceDataModel>(Qry).ToArray();
                    }
                    else
                        return null;
                }
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public Data.Models.User GetUserName(string UserName)
        {
            try
            {
                using (Data.Models.GSTinvoiceContext db = new Data.Models.GSTinvoiceContext())
                {
                    return db.Users.FirstOrDefault(w => w.UserName == UserName);
                }
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}
