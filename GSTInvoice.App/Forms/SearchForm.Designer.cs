namespace GSTInvoice.App.Forms
{
    partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.Dgrd_Search = new System.Windows.Forms.DataGridView();
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Searchwith = new System.Windows.Forms.Label();
            this.Lbl_Searchon = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Lbl_Searchstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrd_Search)).BeginInit();
            this.Pnl_Header.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgrd_Search
            // 
            this.Dgrd_Search.AllowUserToAddRows = false;
            this.Dgrd_Search.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            this.Dgrd_Search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgrd_Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgrd_Search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(129)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgrd_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgrd_Search.ColumnHeadersHeight = 20;
            this.Dgrd_Search.Location = new System.Drawing.Point(4, 50);
            this.Dgrd_Search.MultiSelect = false;
            this.Dgrd_Search.Name = "Dgrd_Search";
            this.Dgrd_Search.ReadOnly = true;
            this.Dgrd_Search.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.Dgrd_Search.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgrd_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgrd_Search.Size = new System.Drawing.Size(742, 251);
            this.Dgrd_Search.TabIndex = 31;
            this.Dgrd_Search.Click += new System.EventHandler(this.Dgrd_Search_Click);
            this.Dgrd_Search.DoubleClick += new System.EventHandler(this.Dgrd_Search_DoubleClick);
            this.Dgrd_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgrd_Search_KeyDown);
            this.Dgrd_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgrd_Search_KeyPress);
            this.Dgrd_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dgrd_Search_KeyUp);
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.Pnl_Header.Controls.Add(this.Label1);
            this.Pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Header.Location = new System.Drawing.Point(0, 25);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(746, 22);
            this.Pnl_Header.TabIndex = 29;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(339, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Search Engine";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.Panel1.Controls.Add(this.Lbl_Searchwith);
            this.Panel1.Controls.Add(this.Lbl_Searchon);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(746, 25);
            this.Panel1.TabIndex = 30;
            // 
            // Lbl_Searchwith
            // 
            this.Lbl_Searchwith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.Lbl_Searchwith.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Searchwith.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Searchwith.Location = new System.Drawing.Point(193, 1);
            this.Lbl_Searchwith.Name = "Lbl_Searchwith";
            this.Lbl_Searchwith.Size = new System.Drawing.Size(550, 24);
            this.Lbl_Searchwith.TabIndex = 2;
            this.Lbl_Searchwith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Searchwith.TextChanged += new System.EventHandler(this.Lbl_Searchwith_TextChanged);
            // 
            // Lbl_Searchon
            // 
            this.Lbl_Searchon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.Lbl_Searchon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Searchon.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Searchon.Location = new System.Drawing.Point(79, 1);
            this.Lbl_Searchon.Name = "Lbl_Searchon";
            this.Lbl_Searchon.Size = new System.Drawing.Size(114, 24);
            this.Lbl_Searchon.TabIndex = 1;
            this.Lbl_Searchon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(1, 1);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 24);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Search by :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Searchstatus
            // 
            this.Lbl_Searchstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(129)))), ((int)(((byte)(203)))));
            this.Lbl_Searchstatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Searchstatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Searchstatus.ForeColor = System.Drawing.Color.White;
            this.Lbl_Searchstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Searchstatus.Location = new System.Drawing.Point(0, 304);
            this.Lbl_Searchstatus.Name = "Lbl_Searchstatus";
            this.Lbl_Searchstatus.Size = new System.Drawing.Size(746, 22);
            this.Lbl_Searchstatus.TabIndex = 33;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 326);
            this.Controls.Add(this.Dgrd_Search);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Lbl_Searchstatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrd_Search)).EndInit();
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView Dgrd_Search;
        internal System.Windows.Forms.Panel Pnl_Header;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Lbl_Searchwith;
        internal System.Windows.Forms.Label Lbl_Searchon;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Lbl_Searchstatus;
    }
}