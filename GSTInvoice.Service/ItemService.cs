using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSTInvoice.Data.Models;

namespace GSTInvoice.Service
{
    public class ItemService
    {
        public Item[] GetItemDescription()
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Items.OrderBy(o => o.Description).ToArray();
                }
            }
            catch 
            {
                throw;
            }
        }

        public UnitOfMeasurement[] GetUnitOfMeasurement()
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.UnitOfMeasurements.OrderBy(o => o.UnitOfMeasurementType).ToArray();
                }
            }
            catch
            {
                throw;
            }
        }

        public void SaveAccount(Item item)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    if (item.Id > 0)
                    {
                        //Update
                        var existingitem = db.Items.Where(w => w.Id == item.Id).FirstOrDefault();
                        if (existingitem != null)
                        {
                            existingitem.Description = item.Description;
                            existingitem.Type = item.Type;
                            existingitem.UnitOfMeasuement = item.UnitOfMeasuement;
                            existingitem.HSN_SACcode = item.HSN_SACcode;
                            existingitem.ItemCode = item.ItemCode;
                            existingitem.TaxRate = item.TaxRate;
                            existingitem.CessAmount = item.CessAmount;
                            existingitem.ItemNotes = item.ItemNotes;
                            db.SaveChanges();
                        }

                    }
                    else
                    {
                        //Insert
                        db.Items.Add(new Item()
                        {
                            Description = item.Description,
                            Type = item.Type,
                            UnitOfMeasuement = item.UnitOfMeasuement,
                            HSN_SACcode = item.HSN_SACcode,
                            ItemCode = item.ItemCode,
                            TaxRate = item.TaxRate,
                            CessAmount = item.CessAmount,
                            ItemNotes = item.ItemNotes,
                            CreatBy = item.CreatBy,
                            CreatDate = item.CreatDate
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

        public void DeleteItemById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    var data = db.Items.FirstOrDefault(W => W.Id == Id);
                    if (data != null)
                    {
                        db.Items.Remove(data);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        
        public Item GetItemById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Items.FirstOrDefault(w => w.Id == Id);
                }
            }
            catch
            {
                throw;
            }
        }
  
        public Item GetItemDataById(int Id)
        {
            try
            {
                using (GSTinvoiceContext db = new GSTinvoiceContext())
                {
                    return db.Items.FirstOrDefault(w => w.Id == Id);
                }
            }
            catch 
            {
                throw;
            }
        }

    }
}
