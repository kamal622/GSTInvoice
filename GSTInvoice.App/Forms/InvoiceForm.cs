using GSTInvoice.Core;
using GSTInvoice.Data.Models;
using GSTInvoice.Service;
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
    public partial class InvoiceForm : Form
    {
        InvoiceTransactionForm invoiceTransData = new InvoiceTransactionForm();
        AccountForm accountForm = new AccountForm();
        ClientForm customer = new ClientForm();
        int invoiceId = 0;
        public int InvoiceId { get; set; }

        AccountService accountService = null;
        ClientService customerservice = null;
        AccountBankDetailService accountBankDetailService = null;
        InvoiceFormService invoiceService = null;
        InvoiceTransactionService invoiceTransactionFormService = null;
        InvoiceListService invoiceListService = null;

        public InvoiceForm()
        {
            InitializeComponent();
            invoiceListService = new InvoiceListService();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

            dtInvoiceDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var dueDate = DateTime.Now.Day + 15;
            if (dueDate > DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                var remanigDays = dueDate - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                if (DateTime.Now.Month == 12)
                {
                    dtDueDate.Value = new DateTime(DateTime.Now.Year+1, 1, remanigDays);
                }
                else
                dtDueDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, remanigDays);
            }
            else
            {
                dtDueDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dueDate);
            }

            if (InvoiceId == 0)
            {
                btnPrint.Enabled = false;
            }

            BindAccount();
            if (InvoiceId > 0)
                GetInvoiceDetails();
            BindInvoiceTransaction();
        }

        private void BindAccount()
        {
            try
            {
                accountService = new AccountService();
                var accountList = accountService.GetAccountList();
                accountList.Insert(0, new Account { Id = 0, BusinessName = "-- Select Account --" });
                comboAccount.ValueMember = "Id";
                comboAccount.DisplayMember = "BusinessName";
                comboAccount.DataSource = accountList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindInvoiceTransaction()
        {
            grdInvoiceData.DataSource = invoiceTransData.invoiceTransData.ToArray();
            this.grdInvoiceData.Columns[0].Visible = false;
            this.grdInvoiceData.Columns[1].Visible = false;
            this.grdInvoiceData.Columns[2].Visible = false;
            this.grdInvoiceData.Columns[9].Visible = false;
            this.grdInvoiceData.Columns[12].Visible = false;
            this.grdInvoiceData.Columns[13].Visible = false;        
        }

        private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCustomerAndBank();
        }

        private void BindCustomerAndBank()
        {
            try
            {
                customerservice = new ClientService();
                int accountId = Convert.ToInt32(comboAccount.SelectedValue);
                var customerList = customerservice.GetClientList(accountId);
                customerList.Insert(0, new Client { Id = 0, BusinessName = "" });
                comboCustomerName.DataSource = customerList.ToArray();
                comboCustomerName.ValueMember = "Id";
                comboCustomerName.DisplayMember = "BusinessName";

                accountBankDetailService = new AccountBankDetailService();
                var bankList = accountBankDetailService.GetAccountBankList(accountId);
                bankList.Insert(0, new AccountBankDetail { Id = 0, BankName = "" });
                comboBank.DataSource = bankList.ToArray();
                comboBank.ValueMember = "Id";
                comboBank.DisplayMember = "BankName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                accountBankDetailService = new AccountBankDetailService();
                int bankId = 0;
                int.TryParse(Convert.ToString(comboBank.SelectedValue), out bankId);
                if (bankId <= 0)
                    return;
                var bankDetails = accountBankDetailService.GetBankDataById(bankId);
                if (bankDetails != null)
                {
                    txtAccountNumber.Text = bankDetails.AccountNumber;
                    txtBranchName.Text = bankDetails.BranchName;
                    txtIFSCcode.Text = bankDetails.IFSCcode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                customerservice = new ClientService();
                int customerId = 0;
                int.TryParse(Convert.ToString(comboCustomerName.SelectedValue), out customerId);
                if (customerId <= 0)
                    return;
                var customerDetails = customerservice.GetClientDataById(customerId);
                if (customerDetails != null)
                {
                    txtGSTIN.Text = customerDetails.GSTIN;
                    txtBillingAddress.Text = customerDetails.Address1 + Environment.NewLine + customerDetails.Address2 + Environment.NewLine + customerDetails.Pincode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkSppingAddEvent(object sender, EventArgs e)
        {
            txtShippingAddress.Text = txtBillingAddress.Text;
        }

        private void btnCustomerName_Click(object sender, EventArgs e)
        {
            customer.ShowDialog();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    Invoice invoiceData = new Invoice();
                    invoiceData.Id = InvoiceId;
                    invoiceData.AccountId = int.Parse(Convert.ToString(comboAccount.SelectedValue));
                    invoiceData.BankId = int.Parse(Convert.ToString(comboBank.SelectedValue));
                    invoiceData.CustomerId = int.Parse(Convert.ToString(comboCustomerName.SelectedValue));
                    invoiceData.SerialNumber = txtSerialNumber.Text;
                    invoiceData.InvoiceDate = dtInvoiceDate.Value;
                    invoiceData.DueDate = dtDueDate.Value;
                    invoiceData.CustomerName = comboCustomerName.Text;
                    invoiceData.ShippingAddress = txtShippingAddress.Text;
                    invoiceData.Reference = txtReference.Text;
                    invoiceData.BillingAddress = txtBillingAddress.Text;
                    invoiceData.GSTIN = txtGSTIN.Text;
                    invoiceData.PlaceOfSupply = txtPlaceOfSupply.Text;
                    invoiceData.CustomerNotes = txtCustomerNotes.Text;
                    invoiceData.TermsAndConditions = txtTermsAndConditions.Text;
                    invoiceData.CreatDate = DateTime.Now;
                    invoiceData.CreatBy = Comman.UserId;

                    var Transaction = grdInvoiceData.DataSource as InvoiceDataModel[];
                    for (int i = 0; i < Transaction.Length; i++)
                    {
                        var Tran = Transaction[i];
                        if (Tran.Id < 0)
                            invoiceData.InvoiceTransactions.Add(new InvoiceTransaction
                            {
                                Id = Tran.Id,
                                ItemId = Tran.ItemId,
                                Qty = Tran.Qty,
                                Rate = Tran.Rate,
                                Discount = Tran.Discount,
                                TaxableValue = Tran.TaxableValue,
                                TaxableRate = decimal.Parse(Tran.TaxableRate),
                                TaxValue = Tran.TaxValue,
                                Percentage = Tran.Percentage,
                                Total = Tran.Total,
                                InvoiceId = Tran.InvoiceId,
                                CreatBy = Comman.UserId,
                                CreatDate = DateTime.Now
                            });
                    }
                    var TransactionData = Transaction.Where(w => w.Id > 0).Select(s => new InvoiceTransaction
                    {
                        Id = s.Id,
                        ItemId = s.ItemId,
                        InvoiceId = s.InvoiceId,
                        Qty = s.Qty,
                        Rate = s.Rate,
                        Discount = s.Discount,
                        TaxableValue = s.TaxableValue,
                        TaxableRate = decimal.Parse(s.TaxableRate),
                        TaxValue = s.TaxValue,
                        Percentage = s.Percentage,
                        Total = s.Total
                    }).ToList();
                    invoiceService = new InvoiceFormService();

                    // check invoiceId  if exixst than update elase save
                    bool isExits = invoiceService.IsInvoiceExits(InvoiceId);
                    if (isExits == true)
                    {
                        if (InvoiceId > 0)
                        {
                            DialogResult result = MessageBox.Show("Invoice already exists. Do you want to update it ?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                invoiceService.SaveInvoice(invoiceData, TransactionData);
                                MessageBox.Show("Invoice Saved", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.None);
                                ClearData();
                            }
                            else
                                MessageBox.Show("Invoice alredy exits");
                        }
                    }
                    else
                    {
                        invoiceService.SaveInvoice(invoiceData, TransactionData);
                        MessageBox.Show("Invoice Saved", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            comboAccount.SelectedIndex = -1;
            comboBank.SelectedIndex = -1;
            comboCustomerName.SelectedIndex = -1;
            txtAccountNumber.Text = String.Empty;
            txtBillingAddress.Text = String.Empty;
            txtBranchName.Text = String.Empty;
            txtCustomerNotes.Text = String.Empty;
            txtGSTIN.Text = String.Empty;
            txtIFSCcode.Text = String.Empty;
            txtPlaceOfSupply.Text = String.Empty;
            txtReference.Text = String.Empty;
            txtSerialNumber.Text = String.Empty;
            txtShippingAddress.Text = String.Empty;
            txtTermsAndConditions.Text = String.Empty;
            grdInvoiceData.DataSource = new InvoiceDataModel[] { };
        }

        private bool ValidateFields()
        {
            string AccountId = String.Empty;
            string SerialNumber = String.Empty;
            string Reference = String.Empty;
            string CustomerId = String.Empty;
            string BillingAddress = String.Empty;
            string ShippingAddress = String.Empty;
            string Gstin = String.Empty;
            string PlaceOfSupply = String.Empty;
            string BankId = String.Empty;
            string CustomerNotes = String.Empty;
            string TermsAndConditions = String.Empty;
            if (comboAccount.Text == "--Select Account--" || comboAccount.SelectedIndex == -1)
            {
                AccountId = "Select Account!\n";
            }
            if (comboCustomerName.Text == "--Select Customer--" || comboCustomerName.SelectedIndex == -1)
            {
                CustomerId = "Select CustomerName!\n";
            }
            if (comboBank.Text == "--Select Bank--" || comboBank.SelectedIndex == -1)
            {
                BankId = "Select Bank!\n";
            }
            if (txtSerialNumber.Text == String.Empty)
            {
                SerialNumber = "SerialNumber is required!\n";
            }
            if (txtReference.Text == String.Empty)
            {
                Reference = "Reference is required!\n";
            }
            if (txtBillingAddress.Text == String.Empty)
            {
                BillingAddress = "BillingAddress is required!\n";
            }
            if (txtShippingAddress.Text == String.Empty)
            {
                ShippingAddress = "ShippingAddress is required!\n";
            }
            if (txtGSTIN.Text == String.Empty)
            {
                Gstin = "GSTIN is required!\n";
            }
            if (txtPlaceOfSupply.Text == String.Empty)
            {
                PlaceOfSupply = "Place Of Supply is required!\n";
            }
            if (txtCustomerNotes.Text == String.Empty)
            {
                CustomerNotes = "Customer Notes is required!\n";
            }
            if (txtTermsAndConditions.Text == String.Empty)
            {
                TermsAndConditions = "Terms And Conditions is required!\n";
            }

            if (AccountId != String.Empty || SerialNumber != String.Empty || Reference != String.Empty || CustomerId != String.Empty ||
                BillingAddress != String.Empty || ShippingAddress != String.Empty || Gstin != String.Empty || PlaceOfSupply != String.Empty ||
                BankId != String.Empty || CustomerNotes != String.Empty || TermsAndConditions != String.Empty)
            {
                MessageBox.Show(AccountId + SerialNumber + Reference + CustomerId + BillingAddress +
                ShippingAddress + Gstin + PlaceOfSupply + BankId + CustomerNotes + TermsAndConditions);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetInvoiceDetails()
        {
            try
            {
                invoiceService = new InvoiceFormService();
                var invoiceData = invoiceService.GetInvoiceById(InvoiceId);
                
                comboAccount.SelectedValue = invoiceData.AccountId;
                var bank = invoiceData.BankId;
                var custName = invoiceData.CustomerId;
                comboBank.SelectedValue = invoiceData.BankId;
                comboCustomerName.Text = invoiceData.CustomerName;
                txtSerialNumber.Text = invoiceData.SerialNumber;
                txtReference.Text = invoiceData.Reference;
                txtPlaceOfSupply.Text = invoiceData.PlaceOfSupply;
                txtBillingAddress.Text = invoiceData.BillingAddress;
                txtShippingAddress.Text = invoiceData.ShippingAddress;
                txtCustomerNotes.Text = invoiceData.CustomerNotes;
                txtTermsAndConditions.Text = invoiceData.TermsAndConditions;

                //Bind Transaction
                invoiceTransactionFormService = new InvoiceTransactionService();
                invoiceTransData.invoiceTransData = invoiceTransactionFormService.GetInvoiceByInvoiceId(InvoiceId);               
                lblTotal.Text = Convert.ToString(invoiceTransData.invoiceTransData.Sum(s => s.Total));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            accountForm.ShowDialog();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                invoiceTransData.Id = 0;
                invoiceTransData.ShowDialog();                
                BindInvoiceTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdInvoiceData.Columns["Delete"].Index)
            {
                DialogResult result = MessageBox.Show("Are you delete invoice transaction?", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    var Id = Convert.ToInt32(this.grdInvoiceData.SelectedRows[0].Cells[0].Value);
                    invoiceTransData.invoiceTransData = invoiceTransData.invoiceTransData.Where(w => w.Id != Id).ToList();
                    BindInvoiceTransaction();
                }
            }
        }

        private void grdInvoiceData_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdInvoiceData.SelectedRows.Count == 0) return;

            InvoiceTransactionForm invoiceTranDT = new InvoiceTransactionForm();

            invoiceTransData.Id = (int)((this.grdInvoiceData.SelectedRows[0].Cells[0]).Value);  
          //  invoiceTransData.BindFormData();         
            invoiceTransData.ShowDialog(); 
            BindInvoiceTransaction();
            //BindBankGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var objInvoice = invoiceListService.GetInvoiceData(InvoiceId);

                var accountId = objInvoice.AccountId;
                var custmerId = objInvoice.CustomerId;
                var accountStateId = accountService.GetAccountById(accountId).StateId;
                var customerStateId = customerservice.GetClientById(custmerId).StateId;

                if (accountStateId == customerStateId)
                {
                TexInvoiceFormIGST texInvoiceForm = new TexInvoiceFormIGST();
                texInvoiceForm.InvoiceId = InvoiceId;
                texInvoiceForm.ShowDialog();
                }
                else
                {
                TexInvoiceForm texInvoiceForm = new TexInvoiceForm();
                texInvoiceForm.InvoiceId = InvoiceId;
                texInvoiceForm.ShowDialog();
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
