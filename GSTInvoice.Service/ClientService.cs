using GSTInvoice.Core;
using GSTInvoice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service
{
    public class ClientService
    {
        public void SaveClient(Client client)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    if (client.Id > 0)
                    {
                        //Update

                        var existingClient = db.Clients.Where(w => w.Id == client.Id).FirstOrDefault();
                        if (existingClient != null)
                        {
                            existingClient.AccountId = client.AccountId;
                            existingClient.BusinessName = client.BusinessName;
                            existingClient.DisplayName = client.DisplayName;
                            existingClient.Email = client.Email;
                            existingClient.GSTIN = client.GSTIN;
                            existingClient.MobileNo = client.MobileNo;
                            existingClient.Address1 = client.Address1;
                            existingClient.Address2 = client.Address2;
                            existingClient.StateId = client.StateId;
                            existingClient.CityId = client.CityId;
                            existingClient.Pincode = client.Pincode;
                            existingClient.UpdateBy = Comman.UserId;
                            existingClient.UpdateDate = DateTime.Now;
                            //      existingClient.DeleteBy = Comman.UserId;
                            //      existingClient.DeleteDate = DateTime.Now;
                            db.SaveChanges();
                        }

                    }
                    else
                    {
                        //Insert

                        db.Clients.Add(new Client()
                        {
                            AccountId = client.AccountId,
                            BusinessName = client.BusinessName,
                            DisplayName = client.DisplayName,
                            Email = client.Email,
                            GSTIN = client.GSTIN,
                            MobileNo = client.MobileNo,
                            PAN = client.PAN,
                            Address1 = client.Address1,
                            Address2 = client.Address2,
                            StateId = client.StateId,
                            CityId = client.CityId,
                            Pincode = client.Pincode,
                            CreatDate = DateTime.Now,
                            CreatBy = Comman.UserId
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

        public bool IsClientExists(string Name)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var data = db.Clients.FirstOrDefault(W => W.BusinessName == Name);
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
        
        public void DeleteClientById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var data = db.Clients.FirstOrDefault(W => W.Id == Id);
                    if (data != null)
                    {
                        db.Clients.Remove(data);
                        db.SaveChanges();
                    }

                    //if (Id > 0)
                    //{
                    //    var existingClient = db.Clients.Where(w => w.Id == Id).FirstOrDefault();
                    //    if (existingClient != null)
                    //    {
                    //        existingClient.IsDeleted = true;
                    //        existingClient.DeleteBy = Comman.UserId;
                    //        existingClient.DeleteDate = DateTime.Now;
                    //        db.SaveChanges();
                    //    }
                    //}
                }
            }
            catch 
            {
                throw;
            }
            
        }
     
        public Client GetClientById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Clients.FirstOrDefault(w => w.Id == Id);
                }
            }
            catch 
            {
                throw;
            }
        }

        public List<Client> GetClientList(int accountId)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Clients.Where(w => w.AccountId == accountId).OrderBy(o => o.BusinessName).ToList();
                }
            }
            catch 
            {
                throw;
            }
        }

        public Client GetClientDataById(int accountId)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Clients.FirstOrDefault(w => w.Id == accountId);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
