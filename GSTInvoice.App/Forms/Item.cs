using System;
using GSTInvoice.Core;
using GSTInvoice.Service;
using System.Windows.Forms;
using GSTInvoice.Data.Models;

namespace GSTInvoice.App.Forms
{
    public partial class ItemForm : Form
    {
        ItemService itemService = null;
        int itemId = 0;

        public ItemForm()
        {
            InitializeComponent();
        }
        
        private void ClearItemFieldsValues()
        {
            txtDescription.Text = String.Empty;
            comboItemType.Text = "SelectItemType";
            comboUnitOfMeasurement.Text = "Select Measurement";
            comboItemType.SelectedIndex = comboUnitOfMeasurement.SelectedIndex = -1;
            txtHSNSACcode.Text = String.Empty;
            txtCode.Text = String.Empty;
            ntxtRate.Text = "0";
            txtAmount.Text = String.Empty;
            txtNotes.Text = String.Empty;
        }

        public enum ItemTypeList
        {
            Goods, Services
        }
        private void ItemForm_Load(object sender, EventArgs e)
        {
            try
            {
            //BindItemType
            comboItemType.DataSource = Enum.GetValues(typeof(ItemTypeList));
            comboItemType.SelectedIndex = -1;
            comboItemType.Text = "Select ItemType";

            //BindUnitIfMesurment
                itemService = new ItemService();
                var list = itemService.GetUnitOfMeasurement();
                comboUnitOfMeasurement.ValueMember = "Id";
                comboUnitOfMeasurement.DisplayMember = "UnitOfMeasurementType";
                comboUnitOfMeasurement.DataSource = list;
                comboUnitOfMeasurement.SelectedIndex = -1;
                comboUnitOfMeasurement.Text = "Select Measurement";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TaxRateKeyPress(object sender, KeyPressEventArgs e)
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

        private void CessKeyPress(object sender, KeyPressEventArgs e)
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

        private void btnFindItemCode_Click(object sender, EventArgs e)
        {
            try
            {
                string Qry = "select i.Id, i.Description, i.Type, i.UnitOfMeasuement, i.HSN_SACcode, i.ItemCode, i.TaxRate, i.CessAmount,  i.ItemNotes from Item i";
                string Colwidth = "";
                string test = "";
                string tblName = "Item";
                CommonModule.ShowSearchengine(txtCode, Qry, 0, "DisplayName", tblName, Colwidth, test, 0);
                
                if (CommonModule.mId > 0)
                {
                    itemService = new ItemService();
                    if (CommonModule.mId > 0)
                    {
                        var itemData = itemService.GetItemById(CommonModule.mId);

                        itemId = itemData.Id;
                        txtDescription.Text = itemData.Description;
                        comboItemType.Text = itemData.Type;
                        comboUnitOfMeasurement.Text = itemData.UnitOfMeasuement;
                        txtHSNSACcode.Text = itemData.HSN_SACcode;
                        txtCode.Text = itemData.ItemCode;
                        ntxtRate.Text = itemData.TaxRate.ToString();
                        txtAmount.Text = itemData.CessAmount.ToString();
                        txtNotes.Text = itemData.ItemNotes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Description = String.Empty;
                string Type = String.Empty;
                string Measurement = String.Empty;
                string HSN_SACcode = String.Empty;

                if (txtDescription.Text == String.Empty)
                {
                    Description = "Description is required!\n";
                }
                if (comboItemType.Text == String.Empty)
                {
                    Type = "Select Item Type!\n";
                }
                if (comboUnitOfMeasurement.Text == String.Empty)
                {
                    Measurement = "Select Unit Of Measurement!\n";
                }
                if (txtHSNSACcode.Text == String.Empty)
                {
                    HSN_SACcode = "HSN/SACcode is required!\n";
                }
                if (Description != String.Empty || Type != String.Empty
                    || Measurement != String.Empty || HSN_SACcode != String.Empty)
                {
                    MessageBox.Show(Description + Type + Measurement + HSN_SACcode);
                }
                else
                {
                    Description = txtDescription.Text;
                    Type = comboItemType.Text;
                    Measurement = comboUnitOfMeasurement.Text;
                    HSN_SACcode = txtHSNSACcode.Text;
                    string ItemCode = txtCode.Text;
                    string ItemNotes = txtNotes.Text;
                    string cessAmount = txtAmount.Text;
                    string taxRate = ntxtRate.Text;
                    Item itemData = new Item();
                    itemData.Id = itemId;
                    itemData.Description = Description;
                    itemData.Type = Type;
                    itemData.UnitOfMeasuement = Measurement;
                    itemData.HSN_SACcode = HSN_SACcode;
                    itemData.ItemCode = ItemCode;
                    itemData.CessAmount = Convert.ToDecimal(cessAmount);
                    itemData.TaxRate = int.Parse(taxRate);
                    itemData.ItemNotes = ItemNotes;
                    itemData.CreatBy = Comman.UserId;
                    itemData.CreatDate = DateTime.Now;
                    itemService = new ItemService();
                    itemService.SaveAccount(itemData);
                    MessageBox.Show("Item added", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearItemFieldsValues();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete Account ?", Comman.Product_Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    itemService = new ItemService();
                    if (itemId > 0)
                    {
                        itemService.DeleteItemById(itemId);
                        ClearItemFieldsValues();
                        MessageBox.Show("Item deleted", Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ClearItemFieldsValues();
        }

        private void btnItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
