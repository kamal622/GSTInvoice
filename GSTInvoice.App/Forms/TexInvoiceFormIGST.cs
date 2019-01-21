using GSTInvoice.Service;
using Microsoft.Reporting.WinForms;
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
    public partial class TexInvoiceFormIGST : Form
    {
        AccountService accountService = new AccountService();
        AccountBankDetailService accountBankDetailService = new AccountBankDetailService();
        ItemService itemService = new ItemService();
        StateService stateService = new StateService();
        InvoiceListService invoiceListService = null;
        InvoiceTransactionService invoiceTransactionService = null;

        public int InvoiceId { get; set; }


        public TexInvoiceFormIGST()
        {
            InitializeComponent();
            invoiceListService = new InvoiceListService();
            invoiceTransactionService = new InvoiceTransactionService();
        }

        private void TexInvoiceFormIGST_Load(object sender, EventArgs e)
        {         
            var objInvoice = invoiceListService.GetInvoiceData(InvoiceId);
            var objInvoiceTransaction = invoiceTransactionService.GetInvoiceTransactionData(InvoiceId);

            var customerNotes = objInvoice.CustomerNotes;
            var termsAndCondition = objInvoice.TermsAndConditions;

            var bankData = accountBankDetailService.GetBankDataById(objInvoice.BankId);

            var accountData = accountService.GetAccountById(objInvoice.AccountId);
            var objState = stateService.GetStateById(accountData.StateId);
            var StateName = objState.StateName;
            var objAccountBusnessName = accountData.BusinessName;
            var objAccountAddress = accountData.Address1
                                 + ", " + accountData.Address2
                                 + ", " + StateName
                                 + " " + accountData.Pincode;
            var objAccountPhone = accountData.MobileNo;
            var objAccountEmail = accountData.Email;

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CustomerNotes", customerNotes));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TermsAndConditions", termsAndCondition));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountBusnessName", objAccountBusnessName));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountAddress", objAccountAddress));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountPhone", objAccountPhone));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountEmail", objAccountEmail));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("InvoiceDate", objInvoice.InvoiceDate.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("SerialNumber", objInvoice.SerialNumber));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Reference", objInvoice.Reference));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CustomerName", objInvoice.CustomerName));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CustomerGSTIN", objInvoice.GSTIN));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BillingAddress", objInvoice.BillingAddress));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ShippingAddress", objInvoice.ShippingAddress));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PlaceOfSupply", objInvoice.PlaceOfSupply));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DueDate", objInvoice.DueDate.ToString()));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BankName", bankData.BankName));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BranchName", bankData.BranchName));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("IFSCcode", bankData.IFSCcode));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountNumber", bankData.AccountNumber));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountGSTIN", accountData.GSTINno));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountState", StateName));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AccountPAN", accountData.PAN));

            var dataSource = new ReportDataSource("GSTInvoiceTransactionsIGST", objInvoiceTransaction);
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }



    }
}
