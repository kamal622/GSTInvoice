using GSTInvoice.Core;
using GSTInvoice.Service;
using GSTInvoice.Service.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using GSTInvoice.Data.Models;

namespace GSTInvoice.App.Forms
{
    public partial class AccountForm : Form
    {
        BankForm bankForm = new BankForm();
        AccountService accountService = null;
        StateService stateService;
        CityService cityService;
        int AccountId = 0;

        public AccountForm()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            AccountId = 0;
            txtFindAccountName.Text = String.Empty;
            txtBusinessName.Text = String.Empty;
            txtGSTINno.Text = String.Empty;
            txtDisplayName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtPAN.Text = String.Empty;
            grdBankDetails.DataSource = null;
            bankForm._bankDetails = new List<BankDetailsModel>() { };
            txtAddressOne.Text = txtAddressTwo.Text = txtPinCode.Text = String.Empty;
            comboState.SelectedIndex = comboCity.SelectedIndex = -1;
            comboState.Text = "-- Select State --";
            comboCity.Text = "-- Select City --";
        }

        private void Dgrd_Bank_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdBankDetails.SelectedRows.Count == 0) return;

            bankForm.Id = (int)((this.grdBankDetails.SelectedRows[0].Cells[0]).Value);
            if (bankForm.Id == 0)
            {
                bankForm.ShowDialog();
                BindBankGrid();
            }
            else
            {
                bankForm.BindFormData();
                bankForm.ShowDialog();
                BindBankGrid();
            }

        }
        private void PageLoad(object sender, EventArgs e)
        {
            //BindBankGrid();
            BindAccountState();
        }

        private void BindAccountState()
        {
            try
            {
                stateService = new StateService();
                var stateList = stateService.GetStateList();
                // stateList.Insert(0,new State {Id = 0, StateName = "-- SelectState --" });
                comboState.ValueMember = "Id";
                comboState.DisplayMember = "StateName";
                comboState.DataSource = stateList;
                comboState.SelectedIndex = -1;
                comboState.Text = "-- SelectState --";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindBankGrid()
        {
            grdBankDetails.DataSource = bankForm._bankDetails.ToArray();
            grdBankDetails.Columns[0].Visible = false;
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            bankForm.Id = 0;
            bankForm.clearField();
            bankForm.ShowDialog();
            BindBankGrid();
        }

        private void btnAccountSave_Click(object sender, EventArgs e)
        {
            try
            {
                string BusinessName = String.Empty;
                string GSTINno = String.Empty;
                string DisplayName = String.Empty;
                string Email = String.Empty;
                string Mobile = String.Empty;
                string PAN = String.Empty;

                string Address1 = String.Empty;
                string Pincode = String.Empty;
                string State, City = String.Empty;

                if (comboState.SelectedIndex == 0 || comboState.SelectedIndex == -1)
                    State = "Select State!\n";
                if (comboCity.SelectedIndex == 0 || comboCity.SelectedIndex == -1)
                    City = "Select City!\n";

                if (txtAddressOne.Text == String.Empty)
                    Address1 = "Address is required!\n";
                if (txtPinCode.Text == String.Empty)
                    Pincode = "Pincode is required!\n";

                if (txtPAN.Text == String.Empty)
                    PAN = "PAN number is required!\n";
                if (txtBusinessName.Text == String.Empty)
                    BusinessName = "Business Name is required!\n";
                if (txtGSTINno.Text == String.Empty)
                    GSTINno = "GSTIN No is required!\n";
                if (txtDisplayName.Text == String.Empty)
                    DisplayName = "Display Name is required!\n";
                if (txtEmail.Text == String.Empty)
                    Email = "Email is required!\n";
                if (txtMobileNo.Text == String.Empty)
                    Mobile = "Mobile No is required!\n";

                if (BusinessName != String.Empty || GSTINno != String.Empty ||
                     DisplayName != String.Empty || Email != String.Empty ||
                     Mobile != String.Empty || PAN != String.Empty)
                {
                    MessageBox.Show(BusinessName + GSTINno + PAN + DisplayName + Email + Mobile);
                }
                else
                {

                    Account accountData = new Account();
                    accountData.Id = AccountId;
                    accountData.BusinessName = txtBusinessName.Text;
                    accountData.DisplayName = txtDisplayName.Text;
                    accountData.Email = txtEmail.Text;
                    accountData.MobileNo = txtMobileNo.Text;
                    accountData.GSTINno = txtGSTINno.Text;
                    accountData.PAN = txtPAN.Text;

                    accountData.Address1 = txtAddressOne.Text;
                    accountData.Address2 = txtAddressTwo.Text;
                    accountData.StateId = int.Parse(Convert.ToString(comboState.SelectedValue));
                    accountData.CityId = int.Parse(Convert.ToString(comboState.SelectedValue));
                    accountData.Pincode = txtPinCode.Text;

                    var bankDetails = grdBankDetails.DataSource as BankDetailsModel[];

                    for (int i = 0; i < bankDetails.Length; i++)
                    {
                        var bankDetail = bankDetails[i];
                        if (bankDetail.Id < 0)
                            accountData.AccountBankDetails.Add(new AccountBankDetail
                            {
                                BankName = bankDetail.BankName,
                                AccountNumber = bankDetail.AccountNumber,
                                BranchName = bankDetail.BranchName,
                                IFSCcode = bankDetail.IFSC
                            });
                    }

                    if (bankDetails.Length.Equals(0))
                    {
                        MessageBox.Show("Insert Bank Information", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var accountBankDetails = bankDetails.Where(w => w.Id > 0).Select(s => new AccountBankDetail
                    {
                        Id = s.Id,
                        AccountNumber = s.AccountNumber,
                        BankName = s.BankName,
                        BranchName = s.BranchName,
                        IFSCcode = s.IFSC
                    }).ToList();

                    accountService = new AccountService();
                    bool isexits = accountService.IsAccountExists(AccountId, txtBusinessName.Text);
                    if (isexits.Equals(true))
                    {
                        if (AccountId > 0)
                        {
                            DialogResult result = MessageBox.Show("Account name already exists. Do you want to update it ?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                accountService.SaveAccount(accountData, accountBankDetails);
                                MessageBox.Show("Account saved.", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.None);
                                txtBusinessName.Focus();
                                ClearData();
                            }
                        }
                        else
                            MessageBox.Show("Account name already exists.", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        accountService.SaveAccount(accountData, accountBankDetails);
                        MessageBox.Show("Account saved", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                CommonModule.HandleException(this, ex);
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete Account ?", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    accountService = new AccountService();

                    if (AccountId > 0)
                    {
                        accountService.DeleteAccountById(AccountId);
                        ClearData();
                        MessageBox.Show("Record deleted", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccountClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccountClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnFindAccountByName_Click(object sender, EventArgs e)
        {
            try
            {
                string Qry = "select a.Id, a.DisplayName, a.BusinessName, a.Email, a.MobileNo, a.GSTINno, a.PAN, a.Address1, a.Address2, a.StateId, a.CityId, a.Pincode, a.CreateBy, a.CreatDate from Account a";
                string Colwidth = "";
                string test = "";
                string tblName = "Account";
                CommonModule.ShowSearchengine(txtBusinessName, Qry, 0, "DisplayName", tblName, Colwidth, test, 0);
                if (CommonModule.mId > 0)
                {
                    AccountId = CommonModule.mId;
                    accountService = new AccountService();
                    if (AccountId > 0)
                    {
                        List<BankDetailsModel> bankDetails = new List<BankDetailsModel>();
                        var accountData = accountService.GetAccountById(AccountId, out bankDetails);
                        AccountId = accountData.Id;
                        txtBusinessName.Text = accountData.BusinessName;
                        txtDisplayName.Text = accountData.DisplayName;
                        txtGSTINno.Text = accountData.GSTINno;
                        txtEmail.Text = accountData.Email;
                        txtMobileNo.Text = accountData.MobileNo;
                        txtPAN.Text = accountData.PAN;

                        txtAddressOne.Text = accountData.Address1;
                        txtAddressTwo.Text = accountData.Address2;
                        comboState.SelectedValue = accountData.StateId;
                        comboCity.SelectedValue = accountData.CityId;
                        txtPinCode.Text = accountData.Pincode;

                        bankForm._bankDetails = bankDetails;
                        BindBankGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityService = new CityService();
            var stateeId = comboState.SelectedValue;
            int stateId = Convert.ToInt32(stateeId);
            var cityList = cityService.GetCityList(stateId);
            if (cityList.Length > 0)
            {
                comboCity.DataSource = cityList;
            }
            else
            {
                comboCity.DataSource = null;
            }
            comboCity.ValueMember = "Id";
            comboCity.DisplayMember = "CityName";

            comboCity.SelectedIndex = -1;
            comboCity.Text = "Select City";
        }

    }
}
