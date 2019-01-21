using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class Account
    {
        public Account()
        {
            this.AccountBankDetails = new List<AccountBankDetail>();
            this.Invoices = new List<Invoice>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string GSTINno { get; set; }
        public string PAN { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string Pincode { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatDate { get; set; }
        public int CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public virtual ICollection<AccountBankDetail> AccountBankDetails { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
