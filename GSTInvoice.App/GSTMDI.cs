using GSTInvoice.App.Forms;
using GSTInvoice.Core;
using GSTInvoice.Service;
using GSTInvoice.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTInvoice.App
{
    public partial class GSTMDI : Form
    {
        private AccountForm accountForm = null;
        private ClientForm clientform = null;
        private ItemForm itemForm = null;
        private InvoiceForm invoiceForm = null;
        private InvoiceListForm invoiceListForm = null;
        private AboutForm ab = null;

        private InvoiceTransactionForm inTranFrm = null;

        public GSTMDI()
        {
            InitializeComponent();
        }

        private void mnuAccount_Click(object sender, EventArgs e)
        {
            if (accountForm == null || accountForm.IsDisposed)
            {
                accountForm = new AccountForm();
                accountForm.Show();
                accountForm.MdiParent = this;
            }
            else
            {
                accountForm.Activate();
            }
        }

        private void mnuClient_Click(object sender, EventArgs e)
        {
            if (clientform == null || clientform.IsDisposed)
            {
                clientform = new ClientForm();
                clientform.Show();
                clientform.MdiParent = this;
            }
            else
            {
                clientform.Activate();
            }
        }

        private void mnuItem_Click(object sender, EventArgs e)
        {
            if (itemForm == null || itemForm.IsDisposed)
            {
                itemForm = new ItemForm();
                itemForm.Show();
                itemForm.MdiParent = this;
            }
            else
            {
                itemForm.Activate();
            }
            
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            if (invoiceForm == null || invoiceForm.IsDisposed)
            {
                invoiceForm = new InvoiceForm();
                invoiceForm.Show();
                invoiceForm.MdiParent = this;
            }
            else
            {
                invoiceForm.Activate();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ab == null || ab.IsDisposed)
                {
                    ab = new AboutForm();
                    ab.Show();
                    ab.MdiParent = this;
                }
                else
                {
                    ab.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceList_Click(object sender, EventArgs e)
        {
            try
            {
                if (invoiceListForm == null || invoiceListForm.IsDisposed)
                {
                    invoiceListForm = new InvoiceListForm();
                    invoiceListForm.Show();
                    invoiceListForm.MdiParent = this;
                }
                else
                {
                    invoiceListForm.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure exit ?", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

    }
}
