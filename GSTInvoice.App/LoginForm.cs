using System;
using System.Windows.Forms;
using GSTInvoice.Core;
using GSTInvoice.Service;

namespace GSTInvoice.App
{
    public partial class LoginForm : Form
    {

        CommanService commanService = null;

        string UserName = "";
        string Password = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                UserName = txtLoginUserName.Text;
                Password = txtLoginPassword.Text;
                if (IsValidateUser(UserName, Password))
                {
                    GSTMDI mainpage = new GSTMDI();
                    mainpage.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsValidateUser(string UserName, string UserPassword)
        {
            string Encodedpassword = "";
            try
            {
                commanService = new CommanService();
                var userData = commanService.GetUserName(UserName);
                if (userData == null)
                {
                    MessageBox.Show("Invalid User,Please Check", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Encodedpassword = Cryptography.EncryptString(UserPassword);
                if (!(string.Compare(userData.Password, Encodedpassword, StringComparison.Ordinal) == 0))
                {
                    MessageBox.Show("Incorrect Password,Please Check", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    Comman.UserId = userData.id;
                    Comman.UserName = userData.UserName;
                    Comman.UserTypeId = userData.UserTypeId;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
