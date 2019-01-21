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
    public partial class InvoiceTransactionForm : Form
    {
        public int Id = 0;
        public List<InvoiceDataModel> invoiceTransData = new List<InvoiceDataModel>();

        public InvoiceTransactionForm()
        {
            InitializeComponent();

            ntxtQty.Text = "0";
            ntxtRate.Text = "0";
            txtTotal.Text = "0";
            ntxtDiscount.Text = "0";
            ntxtPercentage.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();
        }

        private void btnSaveInvoiceData_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboItemDescription.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Item Description");
                }
                else
                {
                    if (this.Id != 0)
                        this.invoiceTransData = this.invoiceTransData.Where(w => w.Id != this.Id).ToList();
                    else
                    {
                        var minId = 0;
                        if (this.invoiceTransData.Any())
                            minId = this.invoiceTransData.Min(m => m.Id);
                        if (minId > 0)
                            minId = 0;
                        this.Id = minId - 1;
                    }

                    this.invoiceTransData.Add(new InvoiceDataModel
                    {
                        Id = this.Id,
                        ItemId = int.Parse(Convert.ToString(comboItemDescription.SelectedValue)),
                        Qty = int.Parse(ntxtQty.Text),
                        Rate = decimal.Parse(ntxtRate.Text),
                        Discount = decimal.Parse(ntxtDiscount.Text),
                        Percentage = int.Parse(ntxtPercentage.Text),
                        TaxableRate = comboTaxableRate.Text,
                       // UnitOfMeasurement  = txtUnitOfMeasurement.Text,
                        TaxableValue = decimal.Parse(txtTaxableValue.Text),
                        TaxValue = decimal.Parse(txtTxtValues.Text),
                        Total = decimal.Parse(txtTotal.Text),
                        CreatDate = DateTime.Now
                    });

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearInvoiceData_Click(object sender, EventArgs e)
        {
            clearItem();
            clearTansaction();
        }
        private void clearItem()
        {
            comboItemDescription.SelectedIndex = -1;
            comboItemDescription.Text = "Description";
            textItemType.Text = "";
            txtUnitOfMeasurement.Text = "";
            txtHSN.Text = "";
        }
        private void clearTansaction()
        {
            ntxtQty.Text = "0";
            ntxtRate.Text = "0";
            ntxtDiscount.Text = "0";
            ntxtPercentage.Text = "0";
            txtTxtValues.Text = "0";
            txtTaxableValue.Text = "0";
            txtTotal.Text = "0";
            comboTaxableRate.SelectedIndex = 0;
        }

        public bool ValidateField()
        {
            try
            {
                string CGST = "";
                if (txtTxtValues.Text == "" || txtTxtValues.Text == null)
                {
                    CGST = "CGST is Required!\n";
                }

                if (CGST != "")
                {
                    MessageBox.Show(CGST);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PageLoadEvent(object sender, EventArgs e)
        {
            try
            {
                ItemService description = new ItemService();
                var Desclist = description.GetItemDescription();
                comboItemDescription.ValueMember = "Id";
                comboItemDescription.DisplayMember = "Description";
                comboItemDescription.DataSource = Desclist.ToArray();

                TaxableRateService rate = new TaxableRateService();
                var list = rate.GetTaxableRate();
                comboTaxableRate.ValueMember = "Id";
                comboTaxableRate.DisplayMember = "TaxableRate1";
                txtTaxableValue.Text = "0";
                comboTaxableRate.DataSource = list;

                if (Id == 0)
                {
                    clearItem();
                    clearTansaction();
                }
                else
                {
                    BindFormData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemDescIndexChange(object sender, EventArgs e)
        {
            ItemData();
        }
        ItemService itemService = null;
        private void ItemData()
        {
            itemService = new ItemService();
            int ItemId = 0;
            int.TryParse(Convert.ToString(comboItemDescription.SelectedValue), out ItemId);
            if (ItemId <= 0)
                return;
            var itemDetails = itemService.GetItemDataById(ItemId);
            if (itemDetails != null)
            {
                textItemType.Text = itemDetails.Type;
                txtHSN.Text = itemDetails.HSN_SACcode;
                txtUnitOfMeasurement.Text = itemDetails.UnitOfMeasuement;
            }
        }

        private void RateIndexChange(object sender, EventArgs e)
        {

        }

        private void IndexChange(object sender, EventArgs e)
        {
            try
            {
                //  comboTaxableRate.Text = "0";
                Decimal amount = Decimal.Parse(txtTaxableValue.Text);
                Decimal rate = Decimal.Parse(comboTaxableRate.Text);
                Decimal txtValue = (amount * rate) / 100;
                txtTxtValues.Text = txtValue.ToString();
                txtTotal.Text = (amount + txtValue).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtKeyPress(object sender, KeyPressEventArgs e)
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

        public void BindFormData()
        {
            try
            {
                var invoiceTranData = this.invoiceTransData.Where(w => w.Id == this.Id).FirstOrDefault();
                ntxtQty.Text = invoiceTranData.Qty.ToString();
                ntxtRate.Text = invoiceTranData.Rate.ToString();
                ntxtDiscount.Text = invoiceTranData.Discount.ToString();
                ntxtPercentage.Text = invoiceTranData.Percentage.ToString();
                txtTaxableValue.Text = invoiceTranData.TaxableValue.ToString();
                txtTxtValues.Text = invoiceTranData.TaxValue.ToString();
                txtTotal.Text = invoiceTranData.Total.ToString();

                ItemService description = new ItemService();
                var Desclist = description.GetItemDescription();
                comboItemDescription.ValueMember = "Id";
                comboItemDescription.DisplayMember = "Description";
                comboItemDescription.DataSource = Desclist.ToArray();

                var ItemIdd = invoiceTranData.ItemId;
                var itemDaatta = itemService.GetItemById(ItemIdd);
                comboItemDescription.Text = itemDaatta.Description;

                TaxableRateService rate = new TaxableRateService();
                var list = rate.GetTaxableRate();
                comboTaxableRate.ValueMember = "Id";
                comboTaxableRate.DisplayMember = "TaxableRate1";
                comboTaxableRate.DataSource = list;

                var TaxableRateValue = invoiceTranData.TaxableRate;
                comboTaxableRate.Text = invoiceTranData.TaxableRate; 
                //comboTaxableRate.SelectedText = invoiceTranData.TaxableRate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static implicit operator string(InvoiceTransactionForm v)
        {
            throw new NotImplementedException();
        }

        private void ntxtQty_ValueChanged(object sender, EventArgs e)
            {
            try
            {
                if (ntxtQty.Text == "" || ntxtRate.Text == "")
                {
                    txtTotal.Text = "0";
                }
                else
                {
                    Decimal Qty = Decimal.Parse(ntxtQty.Text);
                    Decimal Rate = Decimal.Parse(ntxtRate.Text);
                    Decimal total = Qty * Rate;
                    txtTaxableValue.Text = total.ToString();
                    txtTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ntxtRate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ntxtQty.Text == "" || ntxtRate.Text == "")
                {
                    txtTotal.Text = "0";
                }
                else
                {
                    Decimal Qty = Decimal.Parse(ntxtQty.Text);
                    Decimal Rate = Decimal.Parse(ntxtRate.Text);
                    Decimal total = Qty * Rate;
                    txtTaxableValue.Text = total.ToString();
                    txtTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ntxtPercentage_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ntxtPercentage.Text == "")
                {
                    ntxtPercentage.Text = "0";
                }
                if (ntxtQty.Text != null && ntxtRate.Text != null)
                {
                    Decimal Qty = Decimal.Parse(ntxtQty.Text);
                    Decimal Rate = Decimal.Parse(ntxtRate.Text);
                    Decimal Des_Percentage = Decimal.Parse(ntxtPercentage.Text);
                    Decimal amount = Qty * Rate;
                    Decimal Desc_amount = (amount * Des_Percentage) / 100;
                    ntxtDiscount.Text = Desc_amount.ToString();
                    Decimal total = amount - (Desc_amount);
                    txtTaxableValue.Text = total.ToString();
                    txtTotal.Text = txtTaxableValue.Text;
                }
                else
                {
                    txtTaxableValue.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ntxtDiscount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ntxtDiscount.Text == "")
                {
                    ntxtDiscount.Text = "0";
                }
                if (ntxtQty.Text != null && ntxtRate.Text != null)
                {
                   // ntxtPercentage.Text = "0";
                    if (ntxtDiscount.Text == null)
                    {
                        Decimal Qty = Decimal.Parse(ntxtQty.Text);
                        Decimal Rate = Decimal.Parse(ntxtRate.Text);
                        Decimal total = Qty * Rate;
                        txtTaxableValue.Text = total.ToString();
                    }
                    else
                    {
                        ntxtPercentage.Value = 0;
                        Decimal Qty = Decimal.Parse(ntxtQty.Text);
                        Decimal Rate = Decimal.Parse(ntxtRate.Text);
                        Decimal Des_Amount = Decimal.Parse(ntxtDiscount.Text);
                        Decimal total = (Qty * Rate) - Des_Amount;
                        txtTaxableValue.Text = txtTotal.Text = total.ToString();
                        
                    }
                }
                else
                {
                    txtTaxableValue.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
