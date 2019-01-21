using GSTInvoice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GSTInvoice.Service
{
    public class InvoiceFormService
    {
        public void SaveInvoice(Invoice invoice, List<InvoiceTransaction> transactionData)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    if (invoice.Id > 0)
                    {
                        // Update

                        var Ids = transactionData.Select(s => s.Id).ToArray();
                        var deleteInvoiceData = db.InvoiceTransactions.Where(w => w.InvoiceId == invoice.Id && !Ids.Contains(w.Id)).ToArray();
                        db.InvoiceTransactions.RemoveRange(deleteInvoiceData);
                        db.SaveChanges();

                        // Insert new transaction.
                        var newBankAccounts = invoice.InvoiceTransactions.ToArray();
                        for (int i = 0; i < newBankAccounts.Length; i++)
                        {
                            newBankAccounts[i].InvoiceId = invoice.Id;
                            db.InvoiceTransactions.Add(newBankAccounts[i]);
                        }
                        
                        var existingAccount = db.Invoices
                            .Where(w => w.Id == invoice.Id).FirstOrDefault();
                        if (existingAccount != null)
                        {
                            existingAccount.BankId = invoice.BankId;
                        }

                        foreach (var transactionDetail in transactionData)
                        {
                            var existingTansaction= db.InvoiceTransactions.Where(w => w.Id == transactionDetail.Id).FirstOrDefault();
                            if (existingTansaction != null)
                            {                              
                                existingTansaction.Qty = transactionDetail.Qty;
                                existingTansaction.Rate= transactionDetail.Rate;
                                existingTansaction.Discount= transactionDetail.Discount;
                                existingTansaction.Percentage = transactionDetail.Percentage;
                                existingTansaction.TaxableRate = transactionDetail.TaxableRate;
                                existingTansaction.TaxableValue = transactionDetail.TaxableValue;
                                existingTansaction.TaxValue = transactionDetail.TaxValue;
                                existingTansaction.Total = transactionDetail.Total;
                            }
                        }
                        //db.InvoiceTransactions.Add(transactionData);
                        db.SaveChanges();
                    }
                    else
                    {
                        //Insert
                        db.Invoices.Add(invoice);
                        db.SaveChanges();
                    }
                }
            }
            catch 
            {
                throw;
            }
        }

        public Invoice GetInvoiceById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Invoices.FirstOrDefault(w => w.Id == Id);
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
                    var data = db.Invoices.FirstOrDefault(W => W.Id == invoiceId );  
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
    }
}
