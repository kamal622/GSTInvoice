using GSTInvoice.Core;
using GSTInvoice.Service.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTInvoice.App.Forms
{
    public partial class BankForm : Form
    {
        public int Id = 0;
        public List<BankDetailsModel> _bankDetails = new List<BankDetailsModel>();
    
        public BankForm()
        {
            InitializeComponent();
        }

        public void BindFormData()
        {
            try
            {
                var bankDetail = this._bankDetails.Where(w => w.Id == this.Id).FirstOrDefault();
                txtBankName.Text = bankDetail.BankName;
                txtBranchName.Text = bankDetail.BranchName;
                txtAccountNumber.Text = bankDetail.AccountNumber;
                txtIFSC.Text = bankDetail.IFSC;
            }
            catch (Exception ex)
            {
                CommonModule.HandleException(this, ex);
            }
        }

        private bool ValidateField()
        {
            string BankName,BranchName,AccountNumber,ISFC;
            BankName = BranchName = AccountNumber = ISFC = String.Empty;
            if (txtBankName.Text == String.Empty )
            {
                BankName = "BankName is required!\n";
            }
            if (txtIFSC.Text == String.Empty)
            {
                ISFC = "IFSC is required!\n";
            }         
            if (txtBranchName.Text == String.Empty)
            {
                BranchName = "BranchName is required!\n";
            }
                if (txtAccountNumber.Text == String.Empty)
                {
                    AccountNumber = "AccountNumber is required!\n";
                } 
                if (BankName != String.Empty || ISFC != String.Empty || BranchName != String.Empty || AccountNumber != String.Empty)
                {
                    MessageBox.Show(BankName + ISFC + BranchName + AccountNumber);
                    return false;
                }
                else
                {
                    return true;
                }
        }

        public void clearField()
        {
            txtBankName.Text = String.Empty;
            txtAccountNumber.Text = String.Empty;
            txtBranchName.Text = String.Empty;
            txtIFSC.Text = String.Empty;
        }

        private void btnBankSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateField())
                {
                    if (this.Id != 0)
                        this._bankDetails = this._bankDetails.Where(w => w.Id != this.Id).ToList();
                    else
                    {
                        var minId = 0;
                        if (this._bankDetails.Any())
                            minId = this._bankDetails.Min(m => m.Id);
                        if (minId > 0)
                            minId = 0;
                        this.Id = minId - 1;
                    }
                    this._bankDetails.Add(new BankDetailsModel
                    {
                        Id = this.Id,
                        AccountNumber = txtAccountNumber.Text,
                        BankName = txtBankName.Text,
                        BranchName = txtBranchName.Text,
                        IFSC = txtIFSC.Text
                    });
                    clearField();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonModule.HandleException(this, ex);
            }
        }

        private void btnBankDelete_Click(object sender, EventArgs e)
        {
            this._bankDetails = this._bankDetails.Where(w => w.Id != this.Id).ToList();
            this.Close();
        }

        private void btnBankClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnBankClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
