using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class AccountBankDetail
    {
        public AccountBankDetail()
        {
            this.Invoices = new List<Invoice>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCcode { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
