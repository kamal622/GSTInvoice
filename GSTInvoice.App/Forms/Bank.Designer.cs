namespace GSTInvoice.App.Forms
{
    partial class BankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            this.gbBankDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.lblIFSC = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBankDelete = new System.Windows.Forms.Button();
            this.btnBankClear = new System.Windows.Forms.Button();
            this.btnBankClose = new System.Windows.Forms.Button();
            this.btnBankSave = new System.Windows.Forms.Button();
            this.tblPatientBillHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPatientBillHeader = new System.Windows.Forms.Panel();
            this.lblBankHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBankDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblPatientBillHeader.SuspendLayout();
            this.pnlPatientBillHeader.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBankDetails
            // 
            this.gbBankDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbBankDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbBankDetails.Location = new System.Drawing.Point(3, 46);
            this.gbBankDetails.Name = "gbBankDetails";
            this.gbBankDetails.Size = new System.Drawing.Size(471, 81);
            this.gbBankDetails.TabIndex = 1;
            this.gbBankDetails.TabStop = false;
            this.gbBankDetails.Text = "Bank Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.46556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.92562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.8843F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIFSC, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountNumber, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBankName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBranchName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 54);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(335, 30);
            this.txtIFSC.MaxLength = 50;
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(118, 20);
            this.txtIFSC.TabIndex = 4;
            // 
            // lblIFSC
            // 
            this.lblIFSC.AutoSize = true;
            this.lblIFSC.BackColor = System.Drawing.Color.Transparent;
            this.lblIFSC.Location = new System.Drawing.Point(3, 7);
            this.lblIFSC.Margin = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblIFSC.Name = "lblIFSC";
            this.lblIFSC.Size = new System.Drawing.Size(33, 18);
            this.lblIFSC.TabIndex = 9;
            this.lblIFSC.Text = "IFSC code";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(335, 3);
            this.txtAccountNumber.MaxLength = 50;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(118, 20);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Location = new System.Drawing.Point(3, 7);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 7;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankName.Location = new System.Drawing.Point(3, 7);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(63, 13);
            this.lblBankName.TabIndex = 6;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.BackColor = System.Drawing.Color.Transparent;
            this.lblBranchName.Location = new System.Drawing.Point(3, 7);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(72, 13);
            this.lblBranchName.TabIndex = 8;
            this.lblBranchName.Text = "Branch Name";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(96, 3);
            this.txtBankName.MaxLength = 500;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(129, 20);
            this.txtBankName.TabIndex = 1;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(96, 30);
            this.txtBranchName.MaxLength = 500;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(129, 20);
            this.txtBranchName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.btnBankDelete);
            this.panel1.Controls.Add(this.btnBankClear);
            this.panel1.Controls.Add(this.btnBankClose);
            this.panel1.Controls.Add(this.btnBankSave);
            this.panel1.Location = new System.Drawing.Point(243, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnBankDelete
            // 
            this.btnBankDelete.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnBankDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankDelete.ForeColor = System.Drawing.Color.White;
            this.btnBankDelete.Location = new System.Drawing.Point(59, 4);
            this.btnBankDelete.Name = "btnBankDelete";
            this.btnBankDelete.Size = new System.Drawing.Size(56, 30);
            this.btnBankDelete.TabIndex = 1;
            this.btnBankDelete.Text = "&Delete";
            this.btnBankDelete.UseVisualStyleBackColor = true;
            this.btnBankDelete.Click += new System.EventHandler(this.btnBankDelete_Click);
            // 
            // btnBankClear
            // 
            this.btnBankClear.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnBankClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankClear.ForeColor = System.Drawing.Color.White;
            this.btnBankClear.Location = new System.Drawing.Point(115, 4);
            this.btnBankClear.Name = "btnBankClear";
            this.btnBankClear.Size = new System.Drawing.Size(56, 30);
            this.btnBankClear.TabIndex = 2;
            this.btnBankClear.Text = "C&lear";
            this.btnBankClear.UseVisualStyleBackColor = true;
            this.btnBankClear.Click += new System.EventHandler(this.btnBankClear_Click);
            // 
            // btnBankClose
            // 
            this.btnBankClose.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnBankClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankClose.ForeColor = System.Drawing.Color.White;
            this.btnBankClose.Location = new System.Drawing.Point(172, 4);
            this.btnBankClose.Name = "btnBankClose";
            this.btnBankClose.Size = new System.Drawing.Size(56, 30);
            this.btnBankClose.TabIndex = 3;
            this.btnBankClose.Text = "&Close";
            this.btnBankClose.UseVisualStyleBackColor = true;
            this.btnBankClose.Click += new System.EventHandler(this.btnBankClose_Click);
            // 
            // btnBankSave
            // 
            this.btnBankSave.BackgroundImage = global::GSTInvoice.App.Properties.Resources.Button_Bkg;
            this.btnBankSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankSave.ForeColor = System.Drawing.Color.White;
            this.btnBankSave.Location = new System.Drawing.Point(3, 4);
            this.btnBankSave.Name = "btnBankSave";
            this.btnBankSave.Size = new System.Drawing.Size(56, 30);
            this.btnBankSave.TabIndex = 0;
            this.btnBankSave.Text = "&Save";
            this.btnBankSave.UseVisualStyleBackColor = true;
            this.btnBankSave.Click += new System.EventHandler(this.btnBankSave_Click);
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
            this.tblPatientBillHeader.Size = new System.Drawing.Size(480, 40);
            this.tblPatientBillHeader.TabIndex = 4;
            // 
            // pnlPatientBillHeader
            // 
            this.pnlPatientBillHeader.Controls.Add(this.lblBankHeader);
            this.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPatientBillHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientBillHeader.Name = "pnlPatientBillHeader";
            this.pnlPatientBillHeader.Size = new System.Drawing.Size(474, 34);
            this.pnlPatientBillHeader.TabIndex = 0;
            // 
            // lblBankHeader
            // 
            this.lblBankHeader.AutoSize = true;
            this.lblBankHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBankHeader.Location = new System.Drawing.Point(17, 9);
            this.lblBankHeader.Name = "lblBankHeader";
            this.lblBankHeader.Size = new System.Drawing.Size(44, 17);
            this.lblBankHeader.TabIndex = 0;
            this.lblBankHeader.Text = "Bank";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel11.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblBranchName, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(93, 25);
            this.tableLayoutPanel11.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(79, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAccountNumber, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(228, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(104, 25);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblIFSC, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(228, 27);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(53, 25);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblBankName, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(84, 25);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(70, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSTInvoice.App.Properties.Resources.LeftGradiant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 176);
            this.Controls.Add(this.tblPatientBillHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBankDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankForm";
            this.gbBankDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tblPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.ResumeLayout(false);
            this.pnlPatientBillHeader.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbBankDetails;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblIFSC;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBankName;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnBankDelete;
        internal System.Windows.Forms.Button btnBankClear;
        internal System.Windows.Forms.Button btnBankClose;
        internal System.Windows.Forms.Button btnBankSave;
        internal System.Windows.Forms.TableLayoutPanel tblPatientBillHeader;
        internal System.Windows.Forms.Panel pnlPatientBillHeader;
        internal System.Windows.Forms.Label lblBankHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label label3;
    }
}