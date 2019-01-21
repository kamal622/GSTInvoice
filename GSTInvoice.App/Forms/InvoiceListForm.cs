using GSTInvoice.Core;
using GSTInvoice.Service;
using GSTInvoice.Service.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSTInvoice.App.Forms
{
    public partial class InvoiceListForm : Form
    {
        InvoiceListService invoiceListService = null;

        public InvoiceListForm()
        {
            InitializeComponent();
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            dtStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
           // BindInvoiceList();
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            try
            {
            invoiceListService = new InvoiceListService();
            var utilityData = invoiceListService.GetInvoiceList(txtInvoiceNumber.Text, dtStartDate.Value, dtEndDate.Value);
            grdInvoiceList.DataSource = utilityData;
               // this.grdInvoiceList.Columns["SerialNumber"] as InvoiceNumber2;
                this.grdInvoiceList.Columns["Id"].Visible = false;
                this.grdInvoiceList.Columns["AccountId"].Visible = false;
                this.grdInvoiceList.Columns["BankId"].Visible = false;
                this.grdInvoiceList.Columns["CustomerId"].Visible = false;
                this.grdInvoiceList.Columns["CreatDate"].Visible = false;
                this.grdInvoiceList.Columns["CreatBy"].Visible = false;
                this.grdInvoiceList.Columns["Account"].Visible = false;
                this.grdInvoiceList.Columns["AccountBankDetail"].Visible = false;
                this.grdInvoiceList.Columns["InvoiceTransactions"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void grdInvoiceList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.grdInvoiceList.SelectedRows.Count == 0) return;
                int invoiceId = Convert.ToInt32(grdInvoiceList.CurrentRow.Cells["Id"].Value);                
                InvoiceForm invoiceForm = new InvoiceForm();
                invoiceForm.InvoiceId = invoiceId;               
                invoiceForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void invoiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
