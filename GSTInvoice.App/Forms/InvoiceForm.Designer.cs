namespace GSTInvoice.App.Forms
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.chkSameAsBillingAddress = new System.Windows.Forms.CheckBox();
            this.grdInvoiceData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxableValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxableRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.creatDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grepBankDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIFC = new System.Windows.Forms.Label();
            this.comboBank = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtIFSCcode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.grpbCustNotes = new System.Windows.Forms.GroupBox();
            this.txtCustomerNotes = new System.Windows.Forms.TextBox();
            this.grpbTandC = new System.Windows.Forms.GroupBox();
            this.txtTermsAndConditions = new System.Windows.Forms.TextBox();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.grepInvoiceData = new System.Windows.Forms.GroupBox();
            this.chkRoundoffTotal = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.grepInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlaceOfSupplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGSTIN = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRefrence = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.comboCustomerName = new System.Windows.Forms.ComboBox();
            this.txtShippingAddress = new System.Windows.Forms.TextBox();
            this.txtBillingAddress = new System.Windows.Forms.TextBox();
            this.txtPlaceOfSupply = new System.Windows.Forms.TextBox();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnItemClear = new System.Windows.Forms.Button();
            this.tblPatientBillHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientBillHeader = new System.Windows.Forms.Panel();
            this.lblPatientBillHeader = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataModelBindingSource)).BeginInit();
            this.grepBankDetails.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.grpbCustNotes.SuspendLayout();
            this.grpbTandC.SuspendLayout();
            this.grepInvoiceData.SuspendLayout();
            this.grepInvoiceDetails.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblPatientBillHeader.SuspendLayout();
            this.pnlPatientBillHeader.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSameAsBillingAddress
            // 
            this.chkSameAsBillingAddress.AutoSize = true;
            this.chkSameAsBillingAddress.BackColor = System.Drawing.Color.Transparent;
            this.chkSameAsBillingAddress.Location = new System.Drawing.Point(768, 118);
            this.chkSameAsBillingAddress.Name = "chkSameAsBillingAddress";
            this.chkSameAsBillingAddress.Size = new System.Drawing.Size(138, 17);
            this.chkSameAsBillingAddress.TabIndex = 6;
            this.chkSameAsBillingAddress.Text = "Same as Billing Address";
            this.chkSameAsBillingAddress.UseVisualStyleBackColor = false;
            this.chkSameAsBillingAddress.CheckedChanged += new System.EventHandler(this.ChkSppingAddEvent);
            // 
            // grdInvoiceData
            // 
            this.grdInvoiceData.AutoGenerateColumns = false;
            this.grdInvoiceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoiceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.taxableValueDataGridViewTextBoxColumn,
            this.taxableRateDataGridViewTextBoxColumn,
            this.taxValueDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Delete,
            this.creatDateDataGridViewTextBoxColumn,
            this.creatByDataGridViewTextBoxColumn});
            this.grdInvoiceData.DataSource = this.invoiceDataModelBindingSource;
            this.grdInvoiceData.Location = new System.Drawing.Point(6, 36);
            this.grdInvoiceData.Name = "grdInvoiceData";
            this.grdInvoiceData.ReadOnly = true;
            this.grdInvoiceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceData.ShowCellErrors = false;
            this.grdInvoiceData.ShowEditingIcon = false;
            this.grdInvoiceData.ShowRowErrors = false;
            this.grdInvoiceData.Size = new System.Drawing.Size(979, 112);
            this.grdInvoiceData.TabIndex = 0;
            this.grdInvoiceData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.delete_CellClick);
            this.grdInvoiceData.DoubleClick += new System.EventHandler(this.grdInvoiceData_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxableValueDataGridViewTextBoxColumn
            // 
            this.taxableValueDataGridViewTextBoxColumn.DataPropertyName = "TaxableValue";
            this.taxableValueDataGridViewTextBoxColumn.HeaderText = "TaxableValue";
            this.taxableValueDataGridViewTextBoxColumn.Name = "taxableValueDataGridViewTextBoxColumn";
            this.taxableValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxableRateDataGridViewTextBoxColumn
            // 
            this.taxableRateDataGridViewTextBoxColumn.DataPropertyName = "TaxableRate";
            this.taxableRateDataGridViewTextBoxColumn.HeaderText = "TaxableRate";
            this.taxableRateDataGridViewTextBoxColumn.Name = "taxableRateDataGridViewTextBoxColumn";
            this.taxableRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxValueDataGridViewTextBoxColumn
            // 
            this.taxValueDataGridViewTextBoxColumn.DataPropertyName = "TaxValue";
            this.taxValueDataGridViewTextBoxColumn.HeaderText = "TaxValue";
            this.taxValueDataGridViewTextBoxColumn.Name = "taxValueDataGridViewTextBoxColumn";
            this.taxValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // creatDateDataGridViewTextBoxColumn
            // 
            this.creatDateDataGridViewTextBoxColumn.DataPropertyName = "CreatDate";
            this.creatDateDataGridViewTextBoxColumn.HeaderText = "CreatDate";
            this.creatDateDataGridViewTextBoxColumn.Name = "creatDateDataGridViewTextBoxColumn";
            this.creatDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatByDataGridViewTextBoxColumn
            // 
            this.creatByDataGridViewTextBoxColumn.DataPropertyName = "CreatBy";
            this.creatByDataGridViewTextBoxColumn.HeaderText = "CreatBy";
            this.creatByDataGridViewTextBoxColumn.Name = "creatByDataGridViewTextBoxColumn";
            this.creatByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDataModelBindingSource
            // 
            this.invoiceDataModelBindingSource.DataSource = typeof(GSTInvoice.Service.Model.InvoiceDataModel);
            // 
            // grepBankDetails
            // 
            this.grepBankDetails.BackColor = System.Drawing.Color.Transparent;
            this.grepBankDetails.Controls.Add(this.tableLayoutPanel10);
            this.grepBankDetails.Controls.Add(this.comboBank);
            this.grepBankDetails.Controls.Add(this.tableLayoutPanel9);
            this.grepBankDetails.Controls.Add(this.txtIFSCcode);
            this.grepBankDetails.Controls.Add(this.tableLayoutPanel8);
            this.grepBankDetails.Controls.Add(this.txtBranchName);
            this.grepBankDetails.Controls.Add(this.tableLayoutPanel7);
            this.grepBankDetails.Controls.Add(this.txtAccountNumber);
            this.grepBankDetails.Location = new System.Drawing.Point(13, 408);
            this.grepBankDetails.Name = "grepBankDetails";
            this.grepBankDetails.Size = new System.Drawing.Size(991, 51);
            this.grepBankDetails.TabIndex = 4;
            this.grepBankDetails.TabStop = false;
            this.grepBankDetails.Text = "Bank Details";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel10.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblIFC, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(757, 16);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(77, 22);
            this.tableLayoutPanel10.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(63, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 22);
            this.label12.TabIndex = 39;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIFC
            // 
            this.lblIFC.AutoSize = true;
            this.lblIFC.BackColor = System.Drawing.Color.Transparent;
            this.lblIFC.Location = new System.Drawing.Point(3, 0);
            this.lblIFC.Name = "lblIFC";
            this.lblIFC.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblIFC.Size = new System.Drawing.Size(57, 19);
            this.lblIFC.TabIndex = 9;
            this.lblIFC.Text = "IFSC code";
            // 
            // comboBank
            // 
            this.comboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBank.FormattingEnabled = true;
            this.comboBank.Location = new System.Drawing.Point(91, 17);
            this.comboBank.Name = "comboBank";
            this.comboBank.Size = new System.Drawing.Size(147, 21);
            this.comboBank.TabIndex = 1;
            this.comboBank.SelectedIndexChanged += new System.EventHandler(this.comboBank_SelectedIndexChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel9.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblBranchName, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(512, 15);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(97, 22);
            this.tableLayoutPanel9.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(83, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBranchName.Location = new System.Drawing.Point(3, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBranchName.Size = new System.Drawing.Size(72, 19);
            this.lblBranchName.TabIndex = 8;
            this.lblBranchName.Text = "Branch Name";
            // 
            // txtIFSCcode
            // 
            this.txtIFSCcode.Location = new System.Drawing.Point(843, 16);
            this.txtIFSCcode.Name = "txtIFSCcode";
            this.txtIFSCcode.ReadOnly = true;
            this.txtIFSCcode.Size = new System.Drawing.Size(139, 20);
            this.txtIFSCcode.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel8.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblAccountNumber, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(247, 16);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(112, 22);
            this.tableLayoutPanel8.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(98, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Location = new System.Drawing.Point(3, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 19);
            this.lblAccountNumber.TabIndex = 7;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(610, 17);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.Size = new System.Drawing.Size(131, 20);
            this.txtBranchName.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel7.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblBankName, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(82, 22);
            this.tableLayoutPanel7.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(68, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankName.Location = new System.Drawing.Point(0, 0);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBankName.Size = new System.Drawing.Size(63, 19);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Bank Name";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(360, 18);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(142, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // grpbCustNotes
            // 
            this.grpbCustNotes.BackColor = System.Drawing.Color.Transparent;
            this.grpbCustNotes.Controls.Add(this.txtCustomerNotes);
            this.grpbCustNotes.Location = new System.Drawing.Point(13, 465);
            this.grpbCustNotes.Name = "grpbCustNotes";
            this.grpbCustNotes.Size = new System.Drawing.Size(991, 64);
            this.grpbCustNotes.TabIndex = 5;
            this.grpbCustNotes.TabStop = false;
            this.grpbCustNotes.Text = "Customer Notes";
            // 
            // txtCustomerNotes
            // 
            this.txtCustomerNotes.Location = new System.Drawing.Point(6, 15);
            this.txtCustomerNotes.Multiline = true;
            this.txtCustomerNotes.Name = "txtCustomerNotes";
            this.txtCustomerNotes.Size = new System.Drawing.Size(979, 41);
            this.txtCustomerNotes.TabIndex = 0;
            // 
            // grpbTandC
            // 
            this.grpbTandC.BackColor = System.Drawing.Color.Transparent;
            this.grpbTandC.Controls.Add(this.txtTermsAndConditions);
            this.grpbTandC.Location = new System.Drawing.Point(13, 534);
            this.grpbTandC.Name = "grpbTandC";
            this.grpbTandC.Size = new System.Drawing.Size(991, 60);
            this.grpbTandC.TabIndex = 7;
            this.grpbTandC.TabStop = false;
            this.grpbTandC.Text = "Terms and Conditions";
            // 
            // txtTermsAndConditions
            // 
            this.txtTermsAndConditions.Location = new System.Drawing.Point(6, 12);
            this.txtTermsAndConditions.Multiline = true;
            this.txtTermsAndConditions.Name = "txtTermsAndConditions";
            this.txtTermsAndConditions.Size = new System.Drawing.Size(979, 42);
            this.txtTermsAndConditions.TabIndex = 0;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(91, 30);
            this.btnSaveInvoice.TabIndex = 0;
            this.btnSaveInvoice.Text = "&Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackgroundImage = global::GSTInvoice.App.Properties.Resources.add1;
            this.btnAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTransaction.Location = new System.Drawing.Point(958, 9);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(21, 21);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // grepInvoiceData
            // 
            this.grepInvoiceData.BackColor = System.Drawing.Color.Transparent;
            this.grepInvoiceData.Controls.Add(this.chkRoundoffTotal);
            this.grepInvoiceData.Controls.Add(this.lblTotal);
            this.grepInvoiceData.Controls.Add(this.lblGrandTotal);
            this.grepInvoiceData.Controls.Add(this.grdInvoiceData);
            this.grepInvoiceData.Controls.Add(this.btnAddTransaction);
            this.grepInvoiceData.Location = new System.Drawing.Point(13, 225);
            this.grepInvoiceData.Name = "grepInvoiceData";
            this.grepInvoiceData.Size = new System.Drawing.Size(991, 176);
            this.grepInvoiceData.TabIndex = 3;
            this.grepInvoiceData.TabStop = false;
            this.grepInvoiceData.Text = "Invoice Data";
            // 
            // chkRoundoffTotal
            // 
            this.chkRoundoffTotal.AutoSize = true;
            this.chkRoundoffTotal.BackColor = System.Drawing.Color.Transparent;
            this.chkRoundoffTotal.Location = new System.Drawing.Point(672, 157);
            this.chkRoundoffTotal.Name = "chkRoundoffTotal";
            this.chkRoundoffTotal.Size = new System.Drawing.Size(97, 17);
            this.chkRoundoffTotal.TabIndex = 4;
            this.chkRoundoffTotal.Text = "Roundoff Total";
            this.chkRoundoffTotal.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(920, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0000 Rs.";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Location = new System.Drawing.Point(789, 158);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(93, 13);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "GRAND TOTAL : ";
            // 
            // grepInvoiceDetails
            // 
            this.grepInvoiceDetails.BackColor = System.Drawing.Color.Transparent;
            this.grepInvoiceDetails.Controls.Add(this.label13);
            this.grepInvoiceDetails.Controls.Add(this.label11);
            this.grepInvoiceDetails.Controls.Add(this.label9);
            this.grepInvoiceDetails.Controls.Add(this.label7);
            this.grepInvoiceDetails.Controls.Add(this.tableLayoutPanel4);
            this.grepInvoiceDetails.Controls.Add(this.tableLayoutPanel6);
            this.grepInvoiceDetails.Controls.Add(this.dtDueDate);
            this.grepInvoiceDetails.Controls.Add(this.tableLayoutPanel5);
            this.grepInvoiceDetails.Controls.Add(this.tableLayoutPanel2);
            this.grepInvoiceDetails.Controls.Add(this.btnAddCustomer);
            this.grepInvoiceDetails.Controls.Add(this.tableLayoutPanel1);
            this.grepInvoiceDetails.Controls.Add(this.dtInvoiceDate);
            this.grepInvoiceDetails.Controls.Add(this.comboCustomerName);
            this.grepInvoiceDetails.Controls.Add(this.txtShippingAddress);
            this.grepInvoiceDetails.Controls.Add(this.chkSameAsBillingAddress);
            this.grepInvoiceDetails.Controls.Add(this.txtBillingAddress);
            this.grepInvoiceDetails.Controls.Add(this.txtPlaceOfSupply);
            this.grepInvoiceDetails.Controls.Add(this.txtGSTIN);
            this.grepInvoiceDetails.Controls.Add(this.txtReference);
            this.grepInvoiceDetails.Controls.Add(this.txtSerialNumber);
            this.grepInvoiceDetails.Controls.Add(this.lblShippingAddress);
            this.grepInvoiceDetails.Controls.Add(this.lblBillingAddress);
            this.grepInvoiceDetails.Controls.Add(this.lblDueDate);
            this.grepInvoiceDetails.Controls.Add(this.lblInvoiceDate);
            this.grepInvoiceDetails.Location = new System.Drawing.Point(13, 79);
            this.grepInvoiceDetails.Name = "grepInvoiceDetails";
            this.grepInvoiceDetails.Size = new System.Drawing.Size(991, 140);
            this.grepInvoiceDetails.TabIndex = 3;
            this.grepInvoiceDetails.TabStop = false;
            this.grepInvoiceDetails.Text = "Invoice Details";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(614, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 22);
            this.label13.TabIndex = 49;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(849, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 22);
            this.label11.TabIndex = 48;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(814, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(607, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlaceOfSupplay, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(276, 66);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(103, 22);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(81, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlaceOfSupplay
            // 
            this.lblPlaceOfSupplay.AutoSize = true;
            this.lblPlaceOfSupplay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceOfSupplay.Location = new System.Drawing.Point(0, 6);
            this.lblPlaceOfSupplay.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblPlaceOfSupplay.Name = "lblPlaceOfSupplay";
            this.lblPlaceOfSupplay.Size = new System.Drawing.Size(81, 13);
            this.lblPlaceOfSupplay.TabIndex = 9;
            this.lblPlaceOfSupplay.Text = "Place of Supply";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblGSTIN, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 67);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(57, 22);
            this.tableLayoutPanel6.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(43, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGSTIN
            // 
            this.lblGSTIN.AutoSize = true;
            this.lblGSTIN.BackColor = System.Drawing.Color.Transparent;
            this.lblGSTIN.Location = new System.Drawing.Point(0, 6);
            this.lblGSTIN.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblGSTIN.Name = "lblGSTIN";
            this.lblGSTIN.Size = new System.Drawing.Size(40, 13);
            this.lblGSTIN.TabIndex = 35;
            this.lblGSTIN.Text = "GSTIN";
            // 
            // dtDueDate
            // 
            this.dtDueDate.CustomFormat = " ";
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDueDate.Location = new System.Drawing.Point(862, 13);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(123, 20);
            this.dtDueDate.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCustomerName, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(101, 22);
            this.tableLayoutPanel5.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(87, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Location = new System.Drawing.Point(0, 6);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 34;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRefrence, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(277, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(72, 22);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(58, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRefrence
            // 
            this.lblRefrence.AutoSize = true;
            this.lblRefrence.BackColor = System.Drawing.Color.Transparent;
            this.lblRefrence.Location = new System.Drawing.Point(0, 6);
            this.lblRefrence.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRefrence.Name = "lblRefrence";
            this.lblRefrence.Size = new System.Drawing.Size(57, 13);
            this.lblRefrence.TabIndex = 32;
            this.lblRefrence.Text = "Reference";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = global::GSTInvoice.App.Properties.Resources.add1;
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCustomer.Location = new System.Drawing.Point(481, 38);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(21, 21);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnCustomerName_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSerialNumber, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(129, 22);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(115, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSerialNumber.Location = new System.Drawing.Point(0, 6);
            this.lblSerialNumber.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(111, 13);
            this.lblSerialNumber.TabIndex = 30;
            this.lblSerialNumber.Text = "Invoice Serial Number";
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInvoiceDate.Location = new System.Drawing.Point(627, 13);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(123, 20);
            this.dtInvoiceDate.TabIndex = 8;
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomerName.FormattingEnabled = true;
            this.comboCustomerName.Location = new System.Drawing.Point(138, 39);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(337, 21);
            this.comboCustomerName.TabIndex = 2;
            this.comboCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // txtShippingAddress
            // 
            this.txtShippingAddress.Location = new System.Drawing.Point(862, 40);
            this.txtShippingAddress.Multiline = true;
            this.txtShippingAddress.Name = "txtShippingAddress";
            this.txtShippingAddress.Size = new System.Drawing.Size(123, 70);
            this.txtShippingAddress.TabIndex = 7;
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Location = new System.Drawing.Point(627, 39);
            this.txtBillingAddress.Multiline = true;
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.ReadOnly = true;
            this.txtBillingAddress.Size = new System.Drawing.Size(123, 70);
            this.txtBillingAddress.TabIndex = 5;
            // 
            // txtPlaceOfSupply
            // 
            this.txtPlaceOfSupply.Location = new System.Drawing.Point(382, 65);
            this.txtPlaceOfSupply.Name = "txtPlaceOfSupply";
            this.txtPlaceOfSupply.Size = new System.Drawing.Size(145, 20);
            this.txtPlaceOfSupply.TabIndex = 5;
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(138, 67);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.ReadOnly = true;
            this.txtGSTIN.Size = new System.Drawing.Size(129, 20);
            this.txtGSTIN.TabIndex = 13;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(382, 13);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(145, 20);
            this.txtReference.TabIndex = 1;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(138, 13);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(129, 20);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingAddress.Location = new System.Drawing.Point(764, 44);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(89, 13);
            this.lblShippingAddress.TabIndex = 38;
            this.lblShippingAddress.Text = "Shipping Address";
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingAddress.Location = new System.Drawing.Point(542, 46);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(75, 13);
            this.lblBillingAddress.TabIndex = 37;
            this.lblBillingAddress.Text = "Billing Address";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDueDate.Location = new System.Drawing.Point(765, 19);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 33;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceDate.Location = new System.Drawing.Point(542, 19);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(68, 13);
            this.lblInvoiceDate.TabIndex = 31;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Location = new System.Drawing.Point(0, 6);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 36;
            this.lblAccount.Text = "Account";
            // 
            // comboAccount
            // 
            this.comboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccount.FormattingEnabled = true;
            this.comboAccount.Location = new System.Drawing.Point(151, 48);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(337, 21);
            this.comboAccount.TabIndex = 0;
            this.comboAccount.SelectedIndexChanged += new System.EventHandler(this.comboAccount_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnSaveInvoice);
            this.panel1.Controls.Add(this.btnItemClear);
            this.panel1.Location = new System.Drawing.Point(779, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 37);
            this.panel1.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(157, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 30);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnItemClear
            // 
            this.btnItemClear.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnItemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemClear.ForeColor = System.Drawing.Color.White;
            this.btnItemClear.Location = new System.Drawing.Point(96, 4);
            this.btnItemClear.Name = "btnItemClear";
            this.btnItemClear.Size = new System.Drawing.Size(60, 30);
            this.btnItemClear.TabIndex = 1;
            this.btnItemClear.Text = "C&lear";
            this.btnItemClear.UseVisualStyleBackColor = true;
            this.btnItemClear.Click += new System.EventHandler(this.btnItemClear_Click);
            // 
            // tblPatientBillHeader
            // 
            this.tblPatientBillHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.tblPatientBillHeader.ColumnCount = 1;
            this.tblPatientBillHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPatientBillHeader.Controls.Add(this.pnlPatientBillHeader, 0, 0);
            this.tblPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPatientBillHeader.Location = new System.Drawing.Point(0, 0);
            this.tblPatientBillHeader.Name = "tblPatientBillHeader";
            this.tblPatientBillHeader.RowCount = 1;
            this.tblPatientBillHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPatientBillHeader.Size = new System.Drawing.Size(1007, 40);
            this.tblPatientBillHeader.TabIndex = 7;
            // 
            // pnlPatientBillHeader
            // 
            this.pnlPatientBillHeader.Controls.Add(this.lblPatientBillHeader);
            this.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientBillHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientBillHeader.Name = "pnlPatientBillHeader";
            this.pnlPatientBillHeader.Size = new System.Drawing.Size(1001, 34);
            this.pnlPatientBillHeader.TabIndex = 0;
            // 
            // lblPatientBillHeader
            // 
            this.lblPatientBillHeader.AutoSize = true;
            this.lblPatientBillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBillHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientBillHeader.Location = new System.Drawing.Point(17, 9);
            this.lblPatientBillHeader.Name = "lblPatientBillHeader";
            this.lblPatientBillHeader.Size = new System.Drawing.Size(145, 17);
            this.lblPatientBillHeader.TabIndex = 0;
            this.lblPatientBillHeader.Text = "Sales Invoice Form";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = global::GSTInvoice.App.Properties.Resources.add1;
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.Location = new System.Drawing.Point(494, 48);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(21, 21);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAccount, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 48);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(61, 22);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(47, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 22);
            this.label14.TabIndex = 39;
            this.label14.Text = "*";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTInvoice.App.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 641);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.tblPatientBillHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboAccount);
            this.Controls.Add(this.grepInvoiceDetails);
            this.Controls.Add(this.grepInvoiceData);
            this.Controls.Add(this.grpbTandC);
            this.Controls.Add(this.grpbCustNotes);
            this.Controls.Add(this.grepBankDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataModelBindingSource)).EndInit();
            this.grepBankDetails.ResumeLayout(false);
            this.grepBankDetails.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.grpbCustNotes.ResumeLayout(false);
            this.grpbCustNotes.PerformLayout();
            this.grpbTandC.ResumeLayout(false);
            this.grpbTandC.PerformLayout();
            this.grepInvoiceData.ResumeLayout(false);
            this.grepInvoiceData.PerformLayout();
            this.grepInvoiceDetails.ResumeLayout(false);
            this.grepInvoiceDetails.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tblPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkSameAsBillingAddress;
        private System.Windows.Forms.DataGridView grdInvoiceData;
        internal System.Windows.Forms.GroupBox grepBankDetails;
        internal System.Windows.Forms.GroupBox grpbCustNotes;
        internal System.Windows.Forms.GroupBox grpbTandC;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblIFC;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtIFSCcode;
        internal System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.TextBox txtCustomerNotes;
        private System.Windows.Forms.TextBox txtTermsAndConditions;
        private System.Windows.Forms.Button btnAddTransaction;
        internal System.Windows.Forms.GroupBox grepInvoiceData;
        internal System.Windows.Forms.GroupBox grepInvoiceDetails;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.TextBox txtBillingAddress;
        private System.Windows.Forms.TextBox txtPlaceOfSupply;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.Label lblPlaceOfSupplay;
        private System.Windows.Forms.Label lblGSTIN;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblRefrence;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.CheckBox chkRoundoffTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.ComboBox comboCustomerName;
        private System.Windows.Forms.ComboBox comboBank;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox comboAccount;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnItemClear;
        internal System.Windows.Forms.TableLayoutPanel tblPatientBillHeader;
        internal System.Windows.Forms.Panel pnlPatientBillHeader;
        internal System.Windows.Forms.Label lblPatientBillHeader;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.BindingSource invoiceDataModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parsantageDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxableValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxableRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatByDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
    }
}