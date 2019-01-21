using GSTInvoice.Core;
using GSTInvoice.Service;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;


namespace GSTInvoice.App.Forms
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        #region Declaration
        private string mReq_Qry = "";
        private object mReq_Ctrl = null;
        private short mReq_Fieldno = 0;
        private string mDef_Filterfield = "";
        private short mDef_Rowsdiplayed = 0;
        private string mTblName = "";
        private string mReq_Orderbyfield = "";
        private string mReq_Colwidth = "";
        private bool mSearch_Hapnd = false;
        private string mFilterfield = "";
        private string mFilterwith = "";
        private string mReturnvalue = "";
        private string mDef_Topselquery = "";
        

        #endregion

        #region Property
        public string Req_Qry
        {
            set
            {
                mReq_Qry = value;
            }
            get
            {
                return mReq_Qry;
            }
        }
        public object Req_Ctrl
        {
            set
            {
                mReq_Ctrl = value;
            }
        }
        public short Req_Fieldno
        {
            set
            {
                mReq_Fieldno = value;
            }
        }
        public short Def_Rowsdiplayed
        {
            set
            {
                mDef_Rowsdiplayed = value;
            }
        }
        public string tblName
        {
            set
            {
                mTblName = value;
            }
            get
            {
                return mTblName;
            }
        }
        public string Req_Orderbyfield
        {
            set
            {
                mReq_Orderbyfield = value;
            }
        }
        public string Def_Filterfield
        {
            set
            {
                mDef_Filterfield = value;
            }
        }
        public string Req_Colwidth
        {
            set
            {
                mReq_Colwidth = value;
            }
        }
        #endregion

        #region Methods
        private string Query_Builder()
        {
            try
            {
                string Rtn_Qry = mReq_Qry;
                mDef_Topselquery = "Select Top " + (mDef_Rowsdiplayed == 0 ? "100" : mDef_Rowsdiplayed.ToString());
                if (!mSearch_Hapnd)
                {
                    Rtn_Qry = Strings.Replace(Strings.UCase(Rtn_Qry), "SELECT ", mDef_Topselquery);
                    mSearch_Hapnd = true;
                }
                else
                    Rtn_Qry = Strings.Replace(Strings.UCase(Rtn_Qry), mDef_Topselquery, "SELECT ");
                if (mFilterfield.Trim() != "")
                {
                    if (Strings.InStr(1, mFilterfield, "[") == 0)
                        mFilterfield = "[" + mFilterfield + "]";
                    if (Strings.InStr(1, Strings.UCase(Rtn_Qry), "WHERE") > 1)
                        Rtn_Qry = Rtn_Qry + " and " + mFilterfield + " like '" + "%" + Strings.Trim(mFilterwith) + "%'";
                    else
                        Rtn_Qry = Rtn_Qry + " where " + mFilterfield + " like '" + "%" + Strings.Trim(mFilterwith) + "%'";
                }

                if (mReq_Orderbyfield.Trim() != "")
                {
                    if (Strings.InStr(1, mReq_Orderbyfield, "[") == 0)
                        mReq_Orderbyfield = "[" + mReq_Orderbyfield + "]";
                    Rtn_Qry = Rtn_Qry + " Order by " + mReq_Orderbyfield;
                }
                else if (mFilterfield.Trim() != "")
                {
                    if (Strings.InStr(1, mFilterfield, "[") == 0)
                        mFilterfield = "[" + mFilterfield + "]";
                    Rtn_Qry = Rtn_Qry + " Order by " + mFilterfield;
                }

                Lbl_Searchon.Text = mFilterfield.Trim().ToUpper();
                if (Lbl_Searchwith.Text.Trim() == "")
                    Lbl_Searchon.Text = "";
                if (Rtn_Qry == null)
                    Rtn_Qry = "";
                return Rtn_Qry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void Populate_Grid(string Comand_text, string tblName)
        {
            CommanService commanService = null;
            try
            {
                commanService = new CommanService();
                if (Comand_text.Trim() == "")
                    return;
                var data = commanService.GetData(Comand_text, tblName);
                Dgrd_Search.DataSource = data;
                Dgrd_Search.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search()
        {
            Query_Builder();
            string Command_Text = Req_Qry;
            Populate_Grid(Query_Builder(), tblName);
        }

        private void Searchengine_Frm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchengine_Frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (Asc(e.KeyChar) == 39)
                //    e.KeyChar = Chr(96);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgrd_Search_Click(object sender, EventArgs e)
        {
            Select_Filterfield();
        }

        private void Dgrd_Search_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Dgrd_Search.Rows.Count <= 0)
                {
                    return;
                }
                Return_Withvalue(Dgrd_Search.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgrd_Search_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down | e.KeyCode == Keys.End | e.KeyCode == Keys.Home | e.KeyCode == Keys.Left | e.KeyCode == Keys.Next | e.KeyCode == Keys.PageDown | e.KeyCode == Keys.PageUp | e.KeyCode == Keys.Right | e.KeyCode == Keys.Tab | e.KeyCode == Keys.Up)
                {
                    Select_Filterfield();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgrd_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Strings.Asc(e.KeyChar) == (int)System.Windows.Forms.Keys.Back)
                {
                    if (Strings.Len(Lbl_Searchwith.Text) > 0)
                        Lbl_Searchwith.Text = Strings.Left(Lbl_Searchwith.Text, Strings.Len(Lbl_Searchwith.Text) - 1);
                }
                else if (Strings.Asc(e.KeyChar) == (int)System.Windows.Forms.Keys.Tab)
                    Lbl_Searchwith.Text = Lbl_Searchwith.Text.ToUpper();
                else if (Strings.Asc(e.KeyChar) == (int)System.Windows.Forms.Keys.Enter)
                {
                }
                else
                {
                    Lbl_Searchwith.Text = Lbl_Searchwith.Text + e.KeyChar;
                    Lbl_Searchwith.Text = Lbl_Searchwith.Text.ToUpper();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_Searchwith_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mFilterfield.Trim() == "")
                    mFilterfield = mDef_Filterfield;
                mFilterwith = Lbl_Searchwith.Text.Trim();
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear_Values()
        {
            try
            {
                CommonModule.mId = 0;
                //IsFormClear = false;
                mReq_Qry = "";
                mReq_Ctrl = null;
                mReq_Fieldno = 0;
                mDef_Filterfield = "";
                mDef_Rowsdiplayed = 0;
                mReq_Orderbyfield = "";
                mSearch_Hapnd = false;
                mFilterfield = "";
                mFilterwith = "";
                mReturnvalue = "";
                Lbl_Searchwith.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgrd_Search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down | e.KeyCode == Keys.End | e.KeyCode == Keys.Home | e.KeyCode == Keys.Left | e.KeyCode == Keys.Next | e.KeyCode == Keys.PageDown | e.KeyCode == Keys.PageUp | e.KeyCode == Keys.Right | e.KeyCode == Keys.Tab | e.KeyCode == Keys.Up)
                {
                    Select_Filterfield();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Select_Filterfield()
        {
            try
            {
                if (Dgrd_Search.Rows.Count == 0)
                {
                    return;
                }
                if (Dgrd_Search.CurrentRow == null)
                {
                    return;
                }
                int index = Dgrd_Search.CurrentCell.ColumnIndex;
                var data = Dgrd_Search.Columns[index].DataPropertyName;
                mFilterfield = data;
                if (mFilterfield != data)
                {
                    mFilterfield = Dgrd_Search.Columns[Dgrd_Search.CurrentCell.RowIndex].DataPropertyName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Return_Withvalue(int rowindex)
        {
            try
            {
                var data = Dgrd_Search[mReq_Fieldno, rowindex].Value;
                mReturnvalue = Convert.ToString(data);
                CommonModule.mId = Convert.ToInt32(data);
                //if (mReq_Ctrl.Visible)
                //    mReq_Ctrl.focus();
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        
    }
}
