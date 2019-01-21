namespace GSTInvoice.App.Forms
{
    partial class InvoiceListForm
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
            this.tblPatientBillHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientBillHeader = new System.Windows.Forms.Panel();
            this.lblPatientBillHeader = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceStartDate = new System.Windows.Forms.Label();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.grdInvoiceList = new System.Windows.Forms.DataGridView();
            this.tblPatientBillHeader.SuspendLayout();
            this.pnlPatientBillHeader.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).BeginInit();
            this.SuspendLayout();
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
            this.tblPatientBillHeader.Size = new System.Drawing.Size(1153, 40);
            this.tblPatientBillHeader.TabIndex = 7;
            // 
            // pnlPatientBillHeader
            // 
            this.pnlPatientBillHeader.Controls.Add(this.lblPatientBillHeader);
            this.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientBillHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientBillHeader.Name = "pnlPatientBillHeader";
            this.pnlPatientBillHeader.Size = new System.Drawing.Size(1147, 34);
            this.pnlPatientBillHeader.TabIndex = 0;
            // 
            // lblPatientBillHeader
            // 
            this.lblPatientBillHeader.AutoSize = true;
            this.lblPatientBillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBillHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientBillHeader.Location = new System.Drawing.Point(17, 9);
            this.lblPatientBillHeader.Name = "lblPatientBillHeader";
            this.lblPatientBillHeader.Size = new System.Drawing.Size(90, 17);
            this.lblPatientBillHeader.TabIndex = 0;
            this.lblPatientBillHeader.Text = "Invoice List";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbSearch.Controls.Add(this.tableLayoutPanel1);
            this.gbSearch.Location = new System.Drawing.Point(12, 62);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1129, 53);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.65188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.40614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.9375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.328969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.03928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36661F));
            this.tableLayoutPanel1.Controls.Add(this.dtEndDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInvoiceNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtStartDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInvoiceNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInvoiceStartDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchInvoice, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 32);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(424, 6);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(94, 20);
            this.dtEndDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "End Date";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(3, 9);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(73, 13);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Serial Number";
            this.lblInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(265, 6);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(95, 20);
            this.dtStartDate.TabIndex = 3;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(88, 6);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(101, 20);
            this.txtInvoiceNumber.TabIndex = 1;
            // 
            // lblInvoiceStartDate
            // 
            this.lblInvoiceStartDate.AutoSize = true;
            this.lblInvoiceStartDate.Location = new System.Drawing.Point(197, 3);
            this.lblInvoiceStartDate.Margin = new System.Windows.Forms.Padding(3);
            this.lblInvoiceStartDate.Name = "lblInvoiceStartDate";
            this.lblInvoiceStartDate.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblInvoiceStartDate.Size = new System.Drawing.Size(55, 19);
            this.lblInvoiceStartDate.TabIndex = 2;
            this.lblInvoiceStartDate.Text = "Start Date";
            this.lblInvoiceStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSearchInvoice.Location = new System.Drawing.Point(524, 3);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(89, 26);
            this.btnSearchInvoice.TabIndex = 4;
            this.btnSearchInvoice.Text = "Search";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // grdInvoiceList
            // 
            this.grdInvoiceList.AllowUserToAddRows = false;
            this.grdInvoiceList.AllowUserToDeleteRows = false;
            this.grdInvoiceList.Location = new System.Drawing.Point(12, 131);
            this.grdInvoiceList.MultiSelect = false;
            this.grdInvoiceList.Name = "grdInvoiceList";
            this.grdInvoiceList.ReadOnly = true;
            this.grdInvoiceList.RowHeadersVisible = false;
            this.grdInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceList.Size = new System.Drawing.Size(1129, 398);
            this.grdInvoiceList.TabIndex = 9;
            this.grdInvoiceList.DoubleClick += new System.EventHandler(this.grdInvoiceList_DoubleClick);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTInvoice.App.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 541);
            this.Controls.Add(this.tblPatientBillHeader);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.grdInvoiceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceListForm";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            this.tblPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tblPatientBillHeader;
        internal System.Windows.Forms.Panel pnlPatientBillHeader;
        internal System.Windows.Forms.Label lblPatientBillHeader;
        internal System.Windows.Forms.GroupBox gbSearch;
        internal System.Windows.Forms.TextBox txtInvoiceNumber;
        internal System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.DataGridView grdInvoiceList;
        internal System.Windows.Forms.Label lblInvoiceStartDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        internal System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        internal System.Windows.Forms.Label label1;
    }
}