using GSTInvoice.Data.Models;
using GSTInvoice.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GSTInvoice.Service
{
    public class InvoiceTransactionService
    {
        public void SaveTransaction(InvoiceTransaction item)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    if (item.Id > 0)
                    {
                        //Update
                        var existingitem = db.InvoiceTransactions.Where(w => w.Id == item.Id).FirstOrDefault();
                        if (existingitem != null)
                        {
                            existingitem.Qty = item.Qty;
                            existingitem.Rate = item.Rate;
                            existingitem.Discount = item.Discount;
                            existingitem.Percentage = item.Percentage;
                            existingitem.TaxableRate = item.TaxableRate;
                            existingitem.TaxableValue = item.TaxableValue;
                            existingitem.TaxValue = item.TaxValue;
                            existingitem.Total = item.Total;
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        //Insert
                        db.InvoiceTransactions.Add(new InvoiceTransaction()
                        {
                            Qty = item.Qty,
                            Rate = item.Rate,
                            Discount = item.Discount,
                            Percentage = item.Percentage,
                            TaxableValue = item.TaxableValue,
                            TaxableRate = item.TaxableRate,
                            TaxValue = item.TaxValue,
                            Total = item.Total
                        });
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public InvoiceTransaction GetInvoiceById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.InvoiceTransactions.FirstOrDefault(w => w.Id == Id);
                }
            }
            catch 
            {
                throw;
            }
        }

        public InvoiceTransaction[] GetInvoiceTransactionData(string invoiceNumber, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var qry = from a in db.InvoiceTransactions
                              where a.CreatDate >= startDate && a.CreatDate <= endDate
                              select a;
                    return qry.ToArray();
                }
            }
            catch 
            {
                throw;
            }
        }

        public InvoiceTransaction[] GetInvoiceTransactionDt()
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.InvoiceTransactions.OrderBy(o => o.Id).ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<InvoiceDataModel> GetInvoiceByInvoiceId(int InvoiceId)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var qry = from a in db.InvoiceTransactions
                              join b in db.Items on a.ItemId equals b.Id
                              where a.InvoiceId == InvoiceId
                              select new InvoiceDataModel {
                                  Id = a.Id,
                                  ItemId = a.ItemId,
                                  Discount = a.Discount,
                                  InvoiceId = a.InvoiceId,
                                  CreatBy = a.CreatBy,
                                  CreatDate = a.CreatDate,
                                  Percentage = a.Percentage,
                                //  UnitOfMeasurement = b.UnitOfMeasurement,
                                  Qty = a.Qty,
                                  Rate = a.Rate,
                                  TaxableRate = a.TaxableRate.ToString(),
                                  TaxableValue = a.TaxableValue,
                                  Total = a.Total,
                                  TaxValue = a.TaxValue
                              };
                    return qry.ToList();
                }
            }
            catch 
            {
                throw;
            }
        }

        public bool IsInvoiceExits(int invoiceId)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var data = db.InvoiceTransactions.FirstOrDefault(W => W.Id != invoiceId);
                    if (data != null)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch 
            {
                throw;
            }
        }

        public InvoiceTransactionModel[] GetInvoiceTransactionData(int InvoiceId)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var qry = from a in db.InvoiceTransactions
                              join b in db.Items on a.ItemId equals b.Id
                              where a.InvoiceId == InvoiceId
                              select new InvoiceTransactionModel
                              {
                                  IGST = 18,
                                  CGST = 9,
                                  SGST = 9,

                                  Description = b.Description,
                                  HSN_SACcode = b.HSN_SACcode,
                                  ItemCode = b.ItemCode,
                                  UnitOfMeasuement = b.UnitOfMeasuement,
                                  Percentage = a.Percentage,
                                  Discount = a.Discount,
                                  Qty = a.Qty,
                                  Rate = a.Rate,
                                  TaxableRate = a.TaxableRate,
                                  TaxableValue = a.TaxableValue,
                                  TaxValue = a.TaxValue
                              };
                    return qry.ToArray();
                }
            }
            catch 
            {
                throw;
            }
        }

    }
}
