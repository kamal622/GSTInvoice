using GSTInvoice.Core;
using GSTInvoice.Service;
using System;
using System.Windows.Forms;
using GSTInvoice.Data.Models;
using System.Text.RegularExpressions;

namespace GSTInvoice.App.Forms
{
    public partial class ClientForm : Form
    {
        ClientService clientService = null;
        AccountService accountService = null;
        StateService stateService = null;
        CityService cityService = null;
        int clientId = 0;
        
        public ClientForm()
        {
            InitializeComponent();
        }

        private bool ValidateClientFields()
        {
                string PAN = String.Empty, Account = String.Empty, BusinessName = String.Empty,GSTINno = String.Empty,DisplayName = String.Empty,Email = String.Empty,
                       Mobile = String.Empty,AddressOne = String.Empty,State = String.Empty,City = String.Empty,PinCode = String.Empty;
            if (txtPAN.Text == String.Empty)
            {
                PAN = "PAN number is required!\n";
            }
            if (comboAccount.SelectedIndex == -1 || comboAccount.SelectedIndex == 0)
                {
                    Account = "Account is required!\n";
                }
                if (txtBusinessName.Text == String.Empty)
                {
                    BusinessName = "Business Name is required!\n";
                }
                if (txtGSTINno.Text == String.Empty)
                {
                    GSTINno = "GSTIN No is required!\n";
                }
                if (txtDisplayName.Text == String.Empty)
                {
                    DisplayName = "Display Name is required!\n";
                }
                if (txtEmail.Text == String.Empty)
                {
                    Email = "Email is required!\n";
                }
                if (txtMobileNo.Text == String.Empty)
                {
                    Mobile = "Mobile No is required!\n";
                }
                if (txtAddressOne.Text == String.Empty)
                {
                    AddressOne = "Address 1 is required!\n";
                }
                if (comboCity.SelectedIndex == -1)
                {
                    City = "City is required!\n";
                }
                if (comboState.SelectedIndex == -1)
                {
                    State = "State is required!\n";
                }
                if (txtPinCode.Text == String.Empty)
                {
                    PinCode = "PinCode is required!\n";
                }

                ConatctNameValidaton();

                if (PAN != String.Empty || Account != String.Empty || BusinessName != String.Empty 
                || GSTINno != String.Empty || DisplayName != String.Empty 
                || Email != String.Empty || Mobile != String.Empty 
                || AddressOne != String.Empty 
                || State!= String.Empty || City != String.Empty 
                || PinCode != String.Empty )
                {
                    MessageBox.Show(PAN + Account + BusinessName + GSTINno + 
                        DisplayName + Email + Mobile + AddressOne + 
                        State + City + PinCode);
                    return false;
                }
                else
                {
                    return true;
                }
           
        }
        
        private void Client_Load(object sender, EventArgs e)
        {
            BindAccountState();
        }

        private void BindAccountState()
        {
            try
            {
                accountService = new AccountService();
                var clientList = accountService.GetAccountList();
                clientList.Insert(0, new Account { Id = 0, BusinessName = "-- Select Account --" });
                comboAccount.ValueMember = "Id";
                comboAccount.DisplayMember = "BusinessName";
                comboAccount.DataSource = clientList;
                comboAccount.SelectedIndex = -1;
                comboAccount.Text = "-- Select Account --";

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
        
        private bool ValidateMobile()
        {
                decimal i;
                return decimal.TryParse(txtMobileNo.Text, out i);           
        }

        private void PinCodeKeyPress(object sender, KeyPressEventArgs e)
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
        private void MobileKeyPress(object sender, KeyPressEventArgs e)
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

        private void ClearClientFieldsValues()
        {
                clientId = 0;
                txtFindClientName.Text = txtBusinessName.Text = txtGSTINno.Text = 
                txtDisplayName.Text = txtEmail.Text = txtMobileNo.Text = 
                txtAddressOne.Text = txtAddressTwo.Text = txtPinCode.Text = txtPAN.Text = String.Empty;
                comboAccount.SelectedIndex = comboState.SelectedIndex = comboCity.SelectedIndex = -1;
                comboAccount.Text = "-- Select Account --";
                comboState.Text = "-- Select State --";
                comboCity.Text = "-- Select City --";          
        }
        
        private void ConatctNameValidaton()
        {
            try
            {
                clientService = new ClientService();
                bool isexits = clientService.IsClientExists(txtBusinessName.Text);
                if (isexits)
                {
                    if (clientId > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Account is aleardy exits", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBusinessName.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          
        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cityService = new CityService();
                int stateId = Convert.ToInt32(comboState.SelectedValue);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void assignFormFieldsData(Client clientData)
        {
            try
            {
                clientId = clientData.Id;
                comboAccount.SelectedValue = clientData.AccountId;
                txtBusinessName.Text = clientData.BusinessName;
                txtDisplayName.Text = clientData.DisplayName;
                txtGSTINno.Text = clientData.GSTIN;
                txtEmail.Text = clientData.Email;
                txtMobileNo.Text = clientData.MobileNo;
                txtPAN.Text = clientData.PAN;
                txtAddressOne.Text = clientData.Address1;
                txtAddressTwo.Text = clientData.Address2;
                comboState.SelectedValue = clientData.StateId;
                comboCity.SelectedValue = clientData.CityId;
                txtPinCode.Text = clientData.Pincode;

                // btnAccountDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BindFirmCombo()
        {
            try
            {
                accountService = new AccountService();
                var accountList = accountService.GetAccountList();
                comboAccount.ValueMember = "Id";
                comboAccount.DisplayMember = "BusinessName";
                comboAccount.DataSource = accountList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetClientData(int Id)
        {
            try
            {
                clientService = new ClientService();
                if (Id > 0)
                {
                    var ClientData = clientService.GetClientById(Id);
                    assignFormFieldsData(ClientData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindClientByName_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Qry = "select c.Id, c.AccountId, c.DisplayName, c.BusinessName, c.Email, c.MobileNo, c.GSTIN, c.Address1, c.Address2, c.StateId, c.CityId, c.Pincode, c.UpdateBy, c.UpdateDate from Client c";
                string Colwidth = String.Empty;
                string test = String.Empty;
                string tblName = "Client";
                CommonModule.ShowSearchengine(txtBusinessName, Qry, 0, "DisplayName", tblName, Colwidth, test, 0);
                if (CommonModule.mId > 0)
                {
                    GetClientData(CommonModule.mId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AccountForm frmAccount = new AccountForm();
            frmAccount.ShowDialog();
            BindFirmCombo();
        }

        private void btnClientSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidateClientFields())
                {
                    int AccountId = int.Parse(Convert.ToString(comboAccount.SelectedValue)),
                        StateId = int.Parse(Convert.ToString(comboState.SelectedValue)),
                        CityId = int.Parse(Convert.ToString(comboCity.SelectedValue));
                    string PAN = txtPAN.Text,
                           BusinessName = txtBusinessName.Text,
                           DisplayName = txtDisplayName.Text,
                           Email = txtEmail.Text,
                           Mobile = txtMobileNo.Text,
                           GSTINno = txtGSTINno.Text,
                           Address1 = txtAddressOne.Text,
                           Address2 = txtAddressTwo.Text,
                           PinCode = txtPinCode.Text;
                    Client clientData = new Client();
                    clientData.Id = clientId;
                    clientData.AccountId = AccountId;
                    clientData.BusinessName = BusinessName;
                    clientData.DisplayName = DisplayName;
                    clientData.Email = Email;
                    clientData.MobileNo = Mobile;
                    clientData.GSTIN = GSTINno;
                    clientData.PAN = PAN;
                    clientData.Address1 = Address1;
                    clientData.Address2 = Address2;
                    clientData.StateId = StateId;
                    clientData.CityId = CityId;
                    clientData.Pincode = PinCode;
                    clientService = new ClientService();
                    clientService.SaveClient(clientData);
                    MessageBox.Show("Client added", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearClientFieldsValues();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
            DialogResult result = MessageBox.Show("Are you sure to Delete Client ?", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                clientService = new ClientService();
                if (clientId > 0)
                {
                    clientService.DeleteClientById(clientId);
                    ClearClientFieldsValues();
                    MessageBox.Show("Client Deleted", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientClear_Click_1(object sender, EventArgs e)
        {
            ClearClientFieldsValues();
        }

        private void btnClientClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
