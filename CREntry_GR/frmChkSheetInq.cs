using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChkResultLib;
using System.Globalization;
using System.Reflection;

namespace CREntry_GR
{
    public partial class frmChkSheetInq : Form
    {
        string strSelect, serverDb, dbName, userDb, passDb;
        DataAccessClass dac = new DataAccessClass();
        SQLClass sqlCls = new SQLClass();

        public frmChkSheetInq()
        {
            InitializeComponent();
            serverDb = Properties.Settings.Default.serverName;
            dbName = Properties.Settings.Default.dbName;
            userDb = Properties.Settings.Default.userDb;
            passDb = Properties.Settings.Default.passDb;
        }


        private void btnEntryCheckSheet_Click(object sender, EventArgs e)
        {
            frmEntChkSheet fEntChkSheet = new frmEntChkSheet();
            fEntChkSheet.Show();
            this.Hide();
        }

        private void cmbJobCode_DropDown(object sender, EventArgs e)
        {
            cmbJobCode.Items.Clear();
            strSelect = sqlCls.funSelectJobCode();
            DataTable dt = new DataTable();
            dt = dac.funGetDataTable(serverDb, dbName, userDb, passDb, strSelect);
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                    cmbJobCode.Items.Add(dr["JobCode"].ToString().Trim());
            }

        }

        private void cmbItemCode_DropDown(object sender, EventArgs e)
        {
            cmbItemCode.Items.Clear();
            strSelect = sqlCls.funSelectItemCode();
            DataTable dt = new DataTable();
            dt = dac.funGetDataTable(serverDb, dbName, userDb, passDb, strSelect);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    cmbItemCode.Items.Add(dr["ItemCode"].ToString().Trim());
            }
        }

        private void cmbCustomer_DropDown(object sender, EventArgs e)
        {
            cmbCustomer.Items.Clear();
            strSelect = sqlCls.funSelectCustomer();
            DataTable dt = new DataTable();
            dt = dac.funGetDataTable(serverDb, dbName, userDb, passDb, strSelect);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    cmbCustomer.Items.Add(dr["CustName"].ToString().Trim());
            }
        }

        private void mtProdDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mtVal = mtProdDate.Text.Trim();
                if(mtVal.Length == 10)
                {
                    DateTime dt;
                    dt = DateTime.ParseExact(mtProdDate.Text, "dd/MM/yyyy", null);
                    dtProdDate.Value = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                mtProdDate.Clear();
            }
        }

        private void dtProdDate_CloseUp(object sender, EventArgs e)
        {
            DateTime dtProd = dtProdDate.Value;
            string strProdDate = dtProd.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            mtProdDate.Text = strProdDate;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if(cmbJobCode.Text.Trim() == "" && !mtProdDate.MaskFull && cmbItemCode.Text.Trim() == "" && cmbCustomer.Text.Trim() == "")
            {
                MessageBox.Show("Please at least fill one parameter.","WARNING", MessageBoxButtons.OK);
            }
            else
            {
                strSelect = sqlCls.funSelectCheckSheetInq(cmbJobCode.Text.Trim(),
                                                            mtProdDate.Text.Trim(),
                                                            cmbItemCode.Text.Trim(),
                                                            cmbCustomer.Text.Trim());
                DataTable dt = new DataTable();
                dt = dac.funGetDataTable(serverDb, dbName, userDb, passDb, strSelect);
                if (dt.Rows.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvInquiry.Rows.Add();
                        dgvInquiry.Rows[idx].Cells["colJobNo"].Value = dr["CGRCode"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colProdDate"].Value = dr["DProdDate"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colCOINo"].Value = dr["CCOINo"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colCustomerName"].Value = dr["CustName"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colItemCode"].Value = dr["ItemCode"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colGINo"].Value = dr["CGINo"].ToString().Trim();
                        dgvInquiry.Rows[idx].Cells["colCustItemDesc"].Value = dr["CustItemDesc"].ToString().Trim();
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            dgvInquiry.GetType().GetProperty("DoubleBuffered",
                                        BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvInquiry, true, null);
        }
    }
}
