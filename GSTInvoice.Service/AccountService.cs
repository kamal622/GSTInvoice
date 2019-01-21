using GSTInvoice.Core;
using GSTInvoice.Data.Models;
using GSTInvoice.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GSTInvoice.Service
{
    public class AccountService
    {
        public void SaveAccount(Account account, List<AccountBankDetail> accountBankDetails)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    if (account.Id > 0)
                    {
                        // Delete before insert new bank accounts.
                        var Ids = accountBankDetails.Select(s => s.Id).ToArray();
                        var deleteBankDetails = db.AccountBankDetails.Where(w => w.AccountId == account.Id && !Ids.Contains(w.Id)).ToArray();
                        db.AccountBankDetails.RemoveRange(deleteBankDetails);
                        db.SaveChanges();

                        // Insert new bank accounts.
                        var newBankAccounts = account.AccountBankDetails.ToArray();
                        for (int i = 0; i < newBankAccounts.Length; i++)
                        {
                            newBankAccounts[i].AccountId = account.Id;
                            db.AccountBankDetails.Add(newBankAccounts[i]);
                        }

                        // Update existing account and bank details.
                        var existingAccount = db.Accounts.Where(w => w.Id == account.Id).FirstOrDefault();
                        if (existingAccount != null)
                        {
                            existingAccount.BusinessName = account.BusinessName;
                            existingAccount.DisplayName = account.DisplayName;
                            existingAccount.Email = account.Email;
                            existingAccount.GSTINno = account.GSTINno;
                            existingAccount.MobileNo = account.MobileNo;

                            existingAccount.UpdateBy = Comman.UserId;
                            existingAccount.UpdateDate = DateTime.Now;
                        }

                        foreach (var bankDetail in accountBankDetails)
                        {
                            var existingBankDetail = db.AccountBankDetails.Where(w => w.Id == bankDetail.Id).FirstOrDefault();
                            if (existingBankDetail != null)
                            {
                                existingBankDetail.AccountNumber = bankDetail.AccountNumber;
                                existingBankDetail.BankName = bankDetail.BankName;
                                existingBankDetail.BranchName = bankDetail.BranchName;
                                existingBankDetail.IFSCcode = bankDetail.IFSCcode;
                            }
                        }

                        db.SaveChanges();
                    }
                    else
                    {
                        //Insert
                        account.CreatDate = DateTime.Now;
                        account.CreateBy = Comman.UserId;
                        db.Accounts.Add(account);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public bool IsAccountExists(int AccountId, string BusinessName)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var data = db.Accounts.FirstOrDefault(W => W.Id != AccountId && W.BusinessName == BusinessName);
                    if (data != null)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                throw;
            }      
        }

        public void DeleteAccountById(int Id)
        {
            try
            {
            using (GSTinvoiceContext db = new GSTinvoiceContext())
            {
                    var bankData = db.AccountBankDetails.Where(W => W.AccountId == Id);
                    db.AccountBankDetails.RemoveRange(bankData);
                    db.SaveChanges();

                    var data = db.Accounts.FirstOrDefault(W => W.Id == Id);
                    if (data != null)
                    {
                        db.Accounts.Remove(data);
                        db.SaveChanges();
                    }

                    //var account = db.Accounts.FirstOrDefault(W => W.Id == Id);
                    //var existingAccount = db.Accounts.Where(w => w.Id == account.Id).FirstOrDefault();
                    //if (existingAccount != null)
                    //{
                    //    existingAccount.IsDeleted = true;
                    //    existingAccount.DeleteBy = Comman.UserId;
                    //    existingAccount.DeleteDate = DateTime.Now;
                    //}
                    //db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Account> GetAccountList()
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Accounts.OrderBy(o => o.BusinessName).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Account GetAccountById(int Id, out List<BankDetailsModel> bankDetails)
        {
            try
            {
                bankDetails = new List<BankDetailsModel>();
                using (var db = new GSTinvoiceContext())
                {
                    var account = db.Accounts.FirstOrDefault(w => w.Id == Id);
                    bankDetails = db.AccountBankDetails.Where(w => w.AccountId == Id).Select(s => new BankDetailsModel
                    {
                        AccountNumber = s.AccountNumber,
                        BankName = s.BankName,
                        BranchName = s.BranchName,
                        Id = s.Id,
                        IFSC = s.IFSCcode
                    }).ToList();
                    return account;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Account GetAccountById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var account = db.Accounts.FirstOrDefault(w => w.Id == Id);
                    return account;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
