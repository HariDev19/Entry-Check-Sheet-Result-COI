using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChkResultLib;

namespace CREntry_GR
{
    public partial class frmEntChkSheet : Form
    {
        private readonly SQLClass sqlCls = new SQLClass();
        private readonly DataAccessClass dac = new DataAccessClass();
        private string serverName; 
        private string dbName; 
        private string userDb; 
        private readonly string passDb;
        bool ret = false;
        public frmEntChkSheet()
        {
            InitializeComponent();
            serverName = Properties.Settings.Default.serverName;
            dbName = Properties.Settings.Default.dbName;
            userDb = Properties.Settings.Default.userDb;
            passDb = Properties.Settings.Default.passDb;
        }

        private void frmEntry_Load(object sender, EventArgs e)
        {
            dgvCheckSheet.GetType().GetProperty("DoubleBuffered",
                                        BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvCheckSheet, true, null);

        }

        private void btnEntryResult_Click(object sender, EventArgs e)
        {
            if(!funValidateChk())
            {
                return;
            }
            else
            {
                DataTable dtStored = new DataTable();
                funFilldtStored(dtStored);
                frmEntResult fEntResult = new frmEntResult(dtStored, txtJobNo.Text.Trim(), 1);
                fEntResult.Show();
                this.Hide();
            }
            
        }

        private DataTable funFilldtStored(DataTable dtStored)
        {
            DataTable dtTbl = new DataTable();
            foreach (DataGridViewColumn col in dgvCheckSheet.Columns)
            {
                dtTbl.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvCheckSheet.Rows)
            {
                DataRow dRow = dtTbl.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dtTbl.Rows.Add(dRow);
            }

            return dtTbl;
        }

        private bool funValidateChk()
        {
            if (txtJobNo.Text.Trim() == "") { MessageBox.Show("Job No is blank.", "WARNING", MessageBoxButtons.OK); ret = false; }
            else if (txtItemCode.Text.Trim() == "") {MessageBox.Show("Item Code is blank.","WARNING",MessageBoxButtons.OK) ;  ret = false; }
            else if(txtCustomer.Text.Trim() == "") { MessageBox.Show("Customer is blank.", "WARNING", MessageBoxButtons.OK); ret = false; }
            else if(txtSpec.Text.Trim() == "") { MessageBox.Show("Spec is blank.", "WARNING", MessageBoxButtons.OK); ret = false; }
            else if(dgvCheckSheet.Rows.Count == 0) { MessageBox.Show("Test Method doesn't specified.", "WARNING", MessageBoxButtons.OK); ret = false; }
            else { ret = true; }
            return ret;
        }

        private void frmEntChkSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChkSheetInq fChkSheetInq = new frmChkSheetInq();
            fChkSheetInq.Show();
            this.Hide();
        }

        private void btnRetrieveData_Click(object sender, EventArgs e)
        {
            if(txtJobNo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill Job No before retrieve data from Radius.", "WARNING", MessageBoxButtons.OK);
                txtJobNo.Select();
                return;
            }
            else
            {
                string strSelect = sqlCls.funRetrieveDataFromRadius("GR",txtJobNo.Text.Trim());
                DataTable dt = dac.funGetDataTable(serverName, dbName, userDb, passDb, strSelect);
                if (dt.Rows.Count > 0)
                {

                }
            }
        }
    }
}
