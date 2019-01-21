using GSTInvoice.Data.Models;
using GSTInvoice.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class InvoiceListService
    {
        public Invoice[] GetInvoiceList(string invoiceNumber, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var qry = from a in db.Invoices
                              where a.SerialNumber.Contains((string.IsNullOrEmpty(invoiceNumber) ? a.SerialNumber : invoiceNumber))
                              && a.InvoiceDate >= startDate && a.InvoiceDate <= endDate
                              select a;
                    return qry.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public Invoice GetInvoiceData(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var qry = from a in db.Invoices
                              where a.Id == Id
                              select a;
                    return qry.FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }

    } 
}
